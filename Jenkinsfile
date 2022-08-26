node {

stage 'Checkout'

checkout scm



stage 'Build'



bat 'nuget restore JenkinsSimpleApi.sln'

bat "\"${tool 'msbuild'}\" JenkinsSimpleApi.sln /p:Configuration=Release"



stage 'Run Tests'



bat 'nunit3-console JenkinsSimpleApi\\bin\\Release\\JenkinsSimpleApi.dll'

}