# Improved Enhanced Camera First Person Mesh Fix
Synthesis patcher to automate simple fix to "double body" issue with Improved/Enhanced Camera mods for Skyrim/SE/AE.

# How to use/settings
Put into a new Synthesis group. Run it. You may need to make two groups with two instances of this patcher (or more) depending on how many mods you have, due to plugins having a maximum number of masters.

![image](https://github.com/vampiremecha/Improved-Enhanced-Camera-First-Person-Mesh-Fix/assets/137844469/41916b4d-0fac-43ee-81c7-4e5af7d38c48)


## Settings

* Generate Male Fixes: Off by default. Self-explanatory.
* Generate Female Fixes: On by default. Self-explanatory.
* Regex Mods (Source): Makes patcher process only mods that start with the alphanumeric characters as denoted by regular expression. Should only really be used if you have to have multiple instances of this patcher cause of too many mods. Ignores non-english characters and characters that aren't alphanumeric, so if you have a mod that starts with a dollar sign or something, it'll just ignore that character and get the next one.
* Included Mods: Blank by default. If blank, all mods are considered. Only consider the mods that are included in the set. Honestly, only really here cause someone is going to be intimidated by regex, and shouldn't be used if you have more than like 50 mods.
* Excluded Mods: Blank by default. If blank, no mods are excluded from output.

# Explanation of problem
A very specific edge case can occur when using Improved/Enhanced Camera, where a second body is seen while in first-person, typically when using first-person arms with third-person body. Technically, the body would still be seen even if Improved/Enhanced Camera wasn't installed. 

Why this is happening is due to a Bethesda default engine behavior, where if in the plugin the armor addon does not have a valid filepath for the first-person filepath set, the engine will set the first-person to be the same as the third-person mesh. A xedit patcher for Joy of Perspective I saw worked by setting every armor's first-person mesh to blank, to take advantage of this engine behavior. The other source of this issue is when mod authors set the first-person mesh to be the same as the world mesh.

<details> 
  <summary>Example of issue (warning: boobs) </summary>
 
   ![image](https://github.com/vampiremecha/Improved-Enhanced-Camera-First-Person-Mesh-Fix/assets/137844469/01f03005-a809-44f6-931b-a161e1608ef8)
</details>


# How this patcher works
Just a bunch of if conditions to check if the first-person filepath is valid and not the same as the third-person filepath. If not, it puts a valid filepath in, in this case "actors\character\character assets\1stpersonfemalebody_1.nif" or "actors\character\character assets\1stpersonmalebody_1.nif" as these are vanilla Bethesda mesh filepaths. 

# Final thoughts, limitations, feedback
## Limitations
1. This patcher can only really fix things the simple way. The "correct" way to do this would be to take the third-person mesh, pull up Outfit Studio or Blender, delete everything this is between the shoulders so only the arms remain, then use the new mesh as the first-person mesh in the plugin.
1. The other limitation would be that this patcher can't fix mods that would have a valid first-person filepath/mesh but that mesh is the same as the third-person mesh but with a different name. I've only seen one mod that had this issue, but this should be known as a limitation for this patcher.
1. For those with large load orders, you may run into an issue of too many masters (>254). That's a Bethesda engine limitation. Best I could do was add the regex and black/white lists and run multiple instances of the patcher. Or make this into a xedit script so it modifies the original plugins.
 
## Feedback and improvements
Probably not going to touch this unless I have to. I will check for PRs and bugs on occasion.

If anyone wants to use this to make a xedit script so the "too many masters" problem is gone and I don't have to learn Pascal, feel free.

If someone could make a PR to skip unplayable armor, that would be good.
