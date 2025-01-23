pipeline {
    agent any

    environment {
        DOCKER_IMAGE = 'BankingApp'
        DOCKER_TAG = "${env.BUILD_ID}"
               DOTNET_ROOT = '/usr/local/share/dotnet' // Path to the .NET SDK
       PATH = "${DOTNET_ROOT}:/bin:/usr/bin:/opt/homebrew/bin:${env.PATH}" // Ensure DOTNET_ROOT is added to PATH
    }

    stages {
        stage('Clone Repository') {
            steps {
                script {
                    // Clone the repository containing the .NET Core application
                     git branch: 'main', url:'https://github.com/AbubakerNaji/BankingApp.git'
       
                }
            }
        }
        stage('Build Docker Image') {
            steps {
                script {
                    // Build the Docker image
                    docker.build("${DOCKER_IMAGE}:${DOCKER_TAG}")
                }
            }
        }
        stage('Run Tests') {
            steps {
                script {
                    // Run your tests here
                    // For example, if you have unit tests, you can run them using dotnet test
                    bat 'dotnet test' // Ensure you have the necessary test project in your repository
                }
            }
        }
        stage('Deploy') {
            steps {
                script {
                    // Deploy the Docker container
                    docker.image("${DOCKER_IMAGE}:${DOCKER_TAG}").run()
                }
            }
        }
    }

    post {
        success {
            // Notify on success
            echo "Good news! The build was successful. Check it out at ${env.BUILD_URL}"
        }
        failure {
            // Notify on failure
           echo "Unfortunately, the build has failed. Please check the logs at ${env.BUILD_URL}"
        }
       
        }
    }