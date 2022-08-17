For eyelid blendshape control, to make sure the character has the required blendshapes, when exporting from DAZ Studio, do the following:

If you export directly to fbx, in the FBX Export Options dialog click on "Edit Morph Export Rules" and add a rule for each of the following and set the Action for each to "Export":
	facs_ctrl_EyeBlink
	facs_jnt_EyeLookDownLeft
	facs_jnt_EyeLookDownRight
	facs_jnt_EyeLookUpLeft
	facs_jnt_EyeLookUpRight
	facs_bs_EyeLookInLeft_div2
	facs_bs_EyeLookInRight_div2
	facs_bs_EyeLookOutLeft_div2
	facs_bs_EyeLookOutRight_div2

If instead you are using the unofficial DAZ to Unity exporter (https://github.com/danielbui78/UDTU), in the export dialogue enable Morphs and choose these Morphs:
	Eye Blink
	Eye Look In Left
	Eye Look In Right
	Eye Look Out Left
	Eye Look Out Right
	Eye Look Up Right
	Eye Look Up Left
	Eye Look Down Left
	Eye Look Down Right


The preset expects there to be tear and eyelash objects with the default naming. So if your character is based on Genesis8.1Female, the hierarchy must be named like this:

- <name of your character>
	- Genesis8_1Female
		- Female 8_1 Tear.Shape
		- Genesis8_1Female.Shape
		- Genesis8_1FemaleEyelashes.Shape
		- ...
