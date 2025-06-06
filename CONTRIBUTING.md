# Contributing

## HELPING OUT CODING

* Help coding on: https://dev.azure.com/saigkill/JobApplicationManager

## IDEAS

* Add ideas on: https://dev.azure.com/saigkill/JobApplicationManager/_workitems/recentlyupdated/
* I'm using Azure DevOps also to manage my open tasks. If you find a nice Task, and want to work with him, just post it there.

## COOL HACKS via Bugreport

* Open a bugreport on https://dev.azure.com/saigkill/JobApplicationManager/_workitems/recentlyupdated/
* Please use the -u flag when generating the patch as it makes the patch more readable.
* Write a good explanation of what the patch does.
* It is better to use git format-patch command: git format-patch HEAD^

## COOL HACKS via Pullrequest (preferred)

* Fork the repository on Azure DevOps
* Create a new branch from the `develop` branch
* Make your changes
* Document your changes in the `CHANGELOG.md` file. Please use the same format as the other entries.
* Commit your changes
* Push your changes to your fork
* Create a pull request from your fork to the `develop` branch (https://dev.azure.com/saigkill/_git/JobApplicationManager/pullrequestcreate)

## TRANSLATING

* Help to translate JobApplicationManager to your language. I'm proposing to use ResX Manager (https://marketplace.visualstudio.com/items?itemName=TomEnglert.ResXManager)

## STRUCTURE

The development happens on: https://dev.azure.com/saigkill/JobApplicationManager
On Github we have a mirror of the repository: https://github.com/saigkill/JobApplicationManager
You can use Github for Issues. For Pullrequests please use Azure DevOps.

### BRANCHES

#### `master` BRANCH

Contains the latest stable Release.

#### `develop` BRANCH

The master branch is the working directory. All new features and bugfixes should be commited to this branch. This branch is merged into the master branch when a new release is made.

#### PULL REQUESTS

Please base all Pullrequests off the `develop` branch.