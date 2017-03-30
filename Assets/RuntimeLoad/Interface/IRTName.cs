﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;
using System.Collections;
using System.Collections.Generic;

public interface IRTName {
    event UnityAction OnDelete;
    void HandleData(object data);
}