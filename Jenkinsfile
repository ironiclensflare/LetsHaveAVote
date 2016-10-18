node {
    stage('Get source from git') {
        git 'https://github.com/ironiclensflare/LetsHaveAVote.git'
    }
    
    stage('Restore NuGet packages') {
        bat 'C:\\Users\\Stuart\\Desktop\\nuget.exe restore'
    }
    
    stage('Build') {
        bat '"C:\\Program Files (x86)\\MSBuild\\14.0\\Bin\\MSBuild.exe"'
    }
    
    stage('Run unit tests') {
        bat '.\\packages\\NUnit.ConsoleRunner.3.5.0\\tools\\nunit3-console.exe .\\LetsHaveAVote.sln --result:"TestResult.xml;format=nunit2"'
        step([$class: 'NUnitPublisher', testResultsPattern: 'TestResult.xml', debug: false, keepJUnitReports: true, skipJUnitArchiver:false, failIfNoResults: true])
    }
}