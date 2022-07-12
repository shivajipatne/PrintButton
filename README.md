# PrintButton

code ql command process to create a DB :

https://docs.github.com/en/enterprise-cloud@latest/code-security/code-scanning/using-codeql-code-scanning-with-your-existing-ci-system/configuring-codeql-cli-in-your-ci-system


https://codeql.github.com/docs/codeql-cli/creating-codeql-databases/#creating-databases-for-non-compiled-languages


codeql database create ../DB/example-repo --language=cpp  --source-root ../Demo
codeql database analyze ../DB/example-repo --sarif-category=csharp  --format=sarif-latest --output=../DB/example-repo-js.sarif


echo $UPLOAD_TOKEN | codeql github upload-results --repository=my-org/example-repo --ref=refs/heads/main --commit=deb275d2d5fe9a522a0b7bd8b6b6a1c939552718 --sarif=../demo/example-repo-js.sarif --github-auth-stdi
