# Hardware-Agnostic OPC UA Skill Model

[![Build Status](https://cloud.drone.io/api/badges/Pro/opcua-device-skills/status.svg)](https://cloud.drone.io/Pro/opcua-device-skills)

This repository contains the Model.xml files for a generic Hardware-Agnostic OPC UA Skill Model.

Further details on the Model.xml format can be found here:
https://opcua.rocks/custom-information-models/

The model is based on the publication:

S. Profanter, A. Breitkreuz, M. Rickert, and A. Knoll, "A Hardware-Agnostic OPC UA Skill Model for Robot Manipulators and Tools,"
in Proceedings of the IEEE International Conference on Emerging Technologies And Factory Automation (ETFA), Zaragoza, Spain, Sep. 2019

## How to use

The `master` branch only contains the Model.xml files, not the compiled NodeSet2.xml files.

On every push to a branch, an [automatic build](https://cloud.drone.io/Pro/opcua-device-skills) is executed and the resultin model files are pushed back to the branch 'master-published'.

Have a look at the resulting files here:
https://github.com/Pro/opcua-device-skills/tree/master-published/Published