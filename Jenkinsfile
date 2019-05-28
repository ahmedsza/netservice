pipeline {
  agent any
  stages {
    stage('Dev') {
      steps {
        sh '''cd netservice
dotnet publish --configuration release'''
        archiveArtifacts 'netservice/bin/Release/netcoreapp2.2/publish/**.*'
      }
    }
  }
}