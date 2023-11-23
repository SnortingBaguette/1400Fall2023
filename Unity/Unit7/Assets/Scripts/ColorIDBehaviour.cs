using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    public ColorIDDataList colorIDDataListObj;
    private void Start()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
