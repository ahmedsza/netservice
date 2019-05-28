pipeline {
  agent any
  stages {
    stage('Dev') {
      steps {
        sh '''cd netservice
dotnet publish --configuration release'''
        archiveArtifacts '**/*.*'
      }
    }
  }
}