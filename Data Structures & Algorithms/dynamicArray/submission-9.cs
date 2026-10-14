public class DynamicArray {
    
    private int[] backGroundArray;
    private int length; 
    private int capacity;
    public DynamicArray(int capacity) {
        this.capacity = capacity;
        this.length = 0;
        this.backGroundArray = new int[this.capacity];
    }

    public int Get(int i) {
        return this.backGroundArray[i];
    }

    public void Set(int i, int n) {
        this.backGroundArray[i] = n;
    }

    public void PushBack(int n) {
        if(this.length == this.capacity) {
            Resize();
        }
        this.backGroundArray[length] = n;
        this.length++;
    }

      public int PopBack() {
        if (length > 0)
        {
            // soft delete the last element
            length--;
        }
        return this.backGroundArray[length];
    }

    private void Resize() {
        this.capacity = this.capacity * 2;
        var tempArray = new int[this.capacity];
        var index = 0;
        foreach(var element in this.backGroundArray) {
            tempArray[index] = element;
            index++;
        }
        this.backGroundArray = tempArray;
    }

    public int GetSize() {
        return this.length;
    }

    public int GetCapacity() {
        return this.capacity;
    }
}
