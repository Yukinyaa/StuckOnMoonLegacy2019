using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public struct Sprite2DRendererEntity : IComponentData
{
    public List<Texture2D> sprites;
    public int spriteno;
}
public struct ItemData
{
    public int itemCode;
    public int quantity;
}
public struct ItemFilter
{
    public int isWhiteList;//true if white, false if black
    public NativeArray<ItemData> list;
}

public struct ItemStorageEntity : IComponentData
{
    public NativeArray<ItemData> itemData;
    public NativeArray<int> itemfilter;
    public NativeArray<NativeArray<ItemData>> itemInsertRequests;
    public NativeArray<NativeArray<ItemData>> itemExtractRequests;
}

public struct ItemMoverEntity : IComponentData
{
    public int fromEntity;
    public int toEntity;
    public int capacity;
}