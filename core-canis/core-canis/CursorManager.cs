using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000045 RID: 69
public class CursorManager : MonoBehaviour
{
	// Token: 0x06000560 RID: 1376 RVA: 0x00028D5C File Offset: 0x00026F5C
	// Note: this type is marked as 'beforefieldinit'.
	static CursorManager()
	{
		Il2CppClassPointerStore<CursorManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "CursorManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager>.NativeClassPtr);
		CursorManager.NativeFieldInfoPtr_cursors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "cursors");
		CursorManager.NativeFieldInfoPtr_highResThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "highResThreshold");
		CursorManager.NativeFieldInfoPtr_cursorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "cursorMap");
		CursorManager.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "current");
		CursorManager.NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "disabled");
		CursorManager.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "<Version>k__BackingField");
		CursorManager.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664090);
		CursorManager.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664091);
		CursorManager.NativeMethodInfoPtr_get_Current_Public_get_CursorRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664092);
		CursorManager.NativeMethodInfoPtr_set_Current_Private_set_Void_CursorRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664093);
		CursorManager.NativeMethodInfoPtr_get_Hide_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664094);
		CursorManager.NativeMethodInfoPtr_set_Hide_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664095);
		CursorManager.NativeMethodInfoPtr_get_Disabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664096);
		CursorManager.NativeMethodInfoPtr_set_Disabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664097);
		CursorManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664098);
		CursorManager.NativeMethodInfoPtr_SetCursor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664099);
		CursorManager.NativeMethodInfoPtr_HasCursor_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664100);
		CursorManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100664101);
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06000561 RID: 1377 RVA: 0x00028EF4 File Offset: 0x000270F4
	// (set) Token: 0x06000562 RID: 1378 RVA: 0x00028F30 File Offset: 0x00027130
	public unsafe virtual ulong Version
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000563 RID: 1379 RVA: 0x00028F70 File Offset: 0x00027170
	// (set) Token: 0x06000564 RID: 1380 RVA: 0x00028FB0 File Offset: 0x000271B0
	public unsafe CursorRecord Current
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_get_Current_Public_get_CursorRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CursorRecord>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857836, XrefRangeEnd = 857841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_set_Current_Private_set_Void_CursorRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000565 RID: 1381 RVA: 0x00028FF4 File Offset: 0x000271F4
	// (set) Token: 0x06000566 RID: 1382 RVA: 0x00029030 File Offset: 0x00027230
	public unsafe bool Hide
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857841, XrefRangeEnd = 857842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_get_Hide_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857842, XrefRangeEnd = 857843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_set_Hide_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000567 RID: 1383 RVA: 0x00029070 File Offset: 0x00027270
	// (set) Token: 0x06000568 RID: 1384 RVA: 0x000290AC File Offset: 0x000272AC
	public unsafe bool Disabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_get_Disabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 857847, RefRangeEnd = 857848, XrefRangeStart = 857843, XrefRangeEnd = 857847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_set_Disabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x000290EC File Offset: 0x000272EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857848, XrefRangeEnd = 857852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00029120 File Offset: 0x00027320
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 857873, RefRangeEnd = 857876, XrefRangeStart = 857852, XrefRangeEnd = 857873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCursor(string cursorName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cursorName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_SetCursor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00029164 File Offset: 0x00027364
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857876, XrefRangeEnd = 857880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasCursor(string cursorName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cursorName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_HasCursor_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x000291B4 File Offset: 0x000273B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857880, XrefRangeEnd = 857895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CursorManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00003E9C File Offset: 0x0000209C
	public CursorManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x0600056E RID: 1390 RVA: 0x000291F0 File Offset: 0x000273F0
	// (set) Token: 0x0600056F RID: 1391 RVA: 0x00003EA5 File Offset: 0x000020A5
	public unsafe Il2CppReferenceArray<CursorRecord> cursors
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_cursors);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CursorRecord>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_cursors), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000570 RID: 1392 RVA: 0x00029220 File Offset: 0x00027420
	// (set) Token: 0x06000571 RID: 1393 RVA: 0x00003EC4 File Offset: 0x000020C4
	public unsafe Vector2 highResThreshold
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_highResThreshold);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_highResThreshold)) = value;
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000572 RID: 1394 RVA: 0x00029248 File Offset: 0x00027448
	// (set) Token: 0x06000573 RID: 1395 RVA: 0x00003EDF File Offset: 0x000020DF
	public unsafe Dictionary<string, CursorRecord> cursorMap
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_cursorMap);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CursorRecord>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_cursorMap), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000574 RID: 1396 RVA: 0x00029278 File Offset: 0x00027478
	// (set) Token: 0x06000575 RID: 1397 RVA: 0x00003EFE File Offset: 0x000020FE
	public unsafe CursorRecord current
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_current);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CursorRecord>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000576 RID: 1398 RVA: 0x000292A8 File Offset: 0x000274A8
	// (set) Token: 0x06000577 RID: 1399 RVA: 0x00003F1D File Offset: 0x0000211D
	public unsafe bool disabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_disabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_disabled)) = value;
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06000578 RID: 1400 RVA: 0x000292D0 File Offset: 0x000274D0
	// (set) Token: 0x06000579 RID: 1401 RVA: 0x00003F38 File Offset: 0x00002138
	public unsafe ulong _Version_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr__Version_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr__Version_k__BackingField)) = value;
		}
	}

	// Token: 0x040003F7 RID: 1015
	private static readonly IntPtr NativeFieldInfoPtr_cursors;

	// Token: 0x040003F8 RID: 1016
	private static readonly IntPtr NativeFieldInfoPtr_highResThreshold;

	// Token: 0x040003F9 RID: 1017
	private static readonly IntPtr NativeFieldInfoPtr_cursorMap;

	// Token: 0x040003FA RID: 1018
	private static readonly IntPtr NativeFieldInfoPtr_current;

	// Token: 0x040003FB RID: 1019
	private static readonly IntPtr NativeFieldInfoPtr_disabled;

	// Token: 0x040003FC RID: 1020
	private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

	// Token: 0x040003FD RID: 1021
	private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

	// Token: 0x040003FE RID: 1022
	private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

	// Token: 0x040003FF RID: 1023
	private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_CursorRecord_0;

	// Token: 0x04000400 RID: 1024
	private static readonly IntPtr NativeMethodInfoPtr_set_Current_Private_set_Void_CursorRecord_0;

	// Token: 0x04000401 RID: 1025
	private static readonly IntPtr NativeMethodInfoPtr_get_Hide_Public_get_Boolean_0;

	// Token: 0x04000402 RID: 1026
	private static readonly IntPtr NativeMethodInfoPtr_set_Hide_Public_set_Void_Boolean_0;

	// Token: 0x04000403 RID: 1027
	private static readonly IntPtr NativeMethodInfoPtr_get_Disabled_Public_get_Boolean_0;

	// Token: 0x04000404 RID: 1028
	private static readonly IntPtr NativeMethodInfoPtr_set_Disabled_Public_set_Void_Boolean_0;

	// Token: 0x04000405 RID: 1029
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000406 RID: 1030
	private static readonly IntPtr NativeMethodInfoPtr_SetCursor_Public_Void_String_0;

	// Token: 0x04000407 RID: 1031
	private static readonly IntPtr NativeMethodInfoPtr_HasCursor_Public_Boolean_String_0;

	// Token: 0x04000408 RID: 1032
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
