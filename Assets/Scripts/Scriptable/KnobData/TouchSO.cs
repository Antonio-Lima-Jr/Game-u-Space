using UnityEngine;

[CreateAssetMenu( menuName = "Data/TouchSO" )]
public class TouchSO : ScriptableObject
{


    [SerializeField]
    private bool Active = false;
    [SerializeField]
    private int IDTouch;
    [SerializeField]
    private Vector2 StartPosition;
    [SerializeField]
    private Vector2 Direction;
    [SerializeField]
    private Vector2 Delta;

    #region Set and Get ID
    /// <summary>
    /// Set and Get ID finger
    /// </summary>
    /// <param name="ID"></param>
    public void setIDTouch(int ID)
    {
        this.IDTouch = ID;
    }
    public int getIDTouch()
    {
        return this.IDTouch;
    }
    #endregion

    #region Set and Get Active
    /// <summary>
    /// Set and Get Active
    /// </summary>
    /// <param name="active"></param>
    public void setActive(bool active)
    {
        this.Active = active;
    }
    public bool getActive()
    {
        return this.Active;
    }
    #endregion

    #region Set and Get StartPosition
    /// <summary>
    /// Set and Get StartPosition
    /// </summary>
    /// <param name="position"></param>
    public void setStartPosition(Vector2 position)
    {

        this.StartPosition = position;
    }
    public Vector2 getStartPosition()
    {
        return this.StartPosition;
    }
    #endregion

    #region Set and Get Direction
    /// <summary>
    /// Set and Get Direction
    /// </summary>
    /// <param name="direction"></param>
    public void setDirection(Vector2 direction)
    {
        this.Direction = direction;
        setDelta(direction - this.StartPosition);
    }
    public Vector2 getDirection()
    {
        return this.Direction;
    }
    #endregion

    #region Set and Get Delta
    /// <summary>
    /// Set and Get Delta
    /// </summary>
    /// <param name="delta"></param>
    public void setDelta(Vector2 delta)
    {
        this.Delta = delta;
    }
    public Vector2 getDelta()
    {
        return this.Delta;
    }
    #endregion

}
