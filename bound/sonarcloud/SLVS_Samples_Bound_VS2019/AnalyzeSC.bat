REM Make sure the C++ build-wrapper is on the PATH...

call scanner /d:sonar.login=%SONARCLOUD_TOKEN% /d:sonar.host.url=https://sonarcloud.io /o:duncanp-sonar-test /k:slvs_samples_bound_vs2019 /d:sonar.cfamily.build-wrapper-output=build_wrapper_output begin

call  build-wrapper-win-x86-64 --out-dir build_wrapper_output msbuild /t:rebuild

call scanner /d:sonar.login=%SONARCLOUD_TOKEN%  end

