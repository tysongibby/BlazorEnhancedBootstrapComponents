# Blazor Enhanced Bootstrap Components
Basic bootstrap elements combined or modified to improve common UX funtionality not included in bootstrap. Anything that changes the basic appearance of bootstrap is avoided to provide a more consitent user experience.

Components so far:

### Dual Multiple select Blazor component  ###
Holds options available to select in the left select element and selected options in the right select element. 
Set "AvailableOptions" by creating a List of DualSelectOptions: List<DualSelectOption>{ DualSelectOption { Id = int, Value = string } }
"SelectedOptions" retrieves the resulting list of DualSelectOptions that have been selected by the user.
"BoxHeight" allows configuration of the row height of the text box of the multiple select elements.

### Input Text Box
Input Text Box with built in validation and floating label functionality, using one tag.


### Audio 
Use one tag to add audio, including audtio featuers such as loop, allowing download, playback rate, controls, different file types, auto-play, and unsupported browser handling.
  
### Modal
Add a modal message using only one tag.
