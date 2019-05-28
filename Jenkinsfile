pipeline {
  agent any
  stages {
    stage('Dev') {
      steps {
        sh 'dotnet publish --configuration release'
      }
    }
  }
}