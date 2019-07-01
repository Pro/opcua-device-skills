# Hardware-Agnostic OPC UA Skill Model

[![Build Status](https://cloud.drone.io/api/badges/Pro/opcua-device-skills/status.svg)](https://cloud.drone.io/Pro/opcua-device-skills)

This repository contains the Model.xml files for a generic Hardware-Agnostic OPC UA Skill Model.

Further details on the Model.xml format can be found here:
https://opcua.rocks/custom-information-models/

The model is based on the publication:

S. Profanter, A. Breitkreuz, M. Rickert, and A. Knoll, "A Hardware-Agnostic OPC UA Skill Model for Robot Manipulators and Tools,"
in Proceedings of the IEEE International Conference on Emerging Technologies And Factory Automation (ETFA), Zaragoza, Spain, Sep. 2019

The full-text PDF is available here: https://mediatum.ub.tum.de/1507596

## How to use

The `master` branch only contains the `*Model.xml` files, not the compiled NodeSet2.xml files.

On every push to a branch, an [automatic build](https://cloud.drone.io/Pro/opcua-device-skills) is executed and the resultin model files are pushed back to the branch 'master-published'.

Have a look at the resulting files here:
https://github.com/Pro/opcua-device-skills/tree/master-published/Published

If you like to manually build the files on your machine, follow these steps:
(as executed by the automatic build in the [.drone.yml](https://github.com/Pro/opcua-device-skills/blob/master/.drone.yml) file)

This build process is using a pre-built docker container based on the official UA-ModelCompiler source code.
There's currently an open pull-request (https://github.com/OPCFoundation/UA-ModelCompiler/pull/36) to add the necessary docker files to the official repository. In the meantime you can use my docker container:
[sailavid/ua-modelcompiler](https://cloud.docker.com/u/sailavid/repository/docker/sailavid/ua-modelcompiler).

1. Install docker on your machine
2. Clone this repository
3. `cd opcua-device-skills`
4. Then run the docker container for `fortiss_di`:
	```bash
	docker run \
		  --mount type=bind,source=$(pwd),target=/model/src \
		  --entrypoint "/app/PublishModel.sh" \
		  sailavid/ua-modelcompiler \
		   /model/src/fortiss_di/fortissDiModel fortiss_di /model/src/Published
	```
5. Then `fortiss_robotics`:
	```bash
	docker run \
		  --mount type=bind,source=$(pwd),target=/model/src \
		  --entrypoint "/app/PublishModel.sh" \
		  sailavid/ua-modelcompiler \
		   /model/src/fortiss_robotics/fortissRoboticsModel fortiss_robotics /model/src/Published
	```
6. And `kuka_iiwa`:
	```bash
	docker run \
		  --mount type=bind,source=$(pwd),target=/model/src \
		  --entrypoint "/app/PublishModel.sh" \
		  sailavid/ua-modelcompiler \
		   /model/src/kuka_iiwa/kukaIiwaModel kuka_iiwa /model/src/Published
	```

This will create all the compiled NodeSet2.xml files inside the `Published` folder.
With this command you can also compiler your own model files, just adapt the last line accordingly.