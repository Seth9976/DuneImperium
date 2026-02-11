using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x0200002C RID: 44
	public class WaypointPath : MonoBehaviour
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		// Note: this type is marked as 'beforefieldinit'.
		static WaypointPath()
		{
			Il2CppClassPointerStore<WaypointPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "WaypointPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr);
			WaypointPath.NativeFieldInfoPtr_StartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, "StartPoint");
			WaypointPath.NativeFieldInfoPtr_EndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, "EndPoint");
			WaypointPath.NativeFieldInfoPtr_waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, "waypoints");
			WaypointPath.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, "color");
			WaypointPath.NativeFieldInfoPtr_reversedWaypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, "reversedWaypoints");
			WaypointPath.NativeFieldInfoPtr_waypointProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, "waypointProvider");
			WaypointPath.NativeMethodInfoPtr_get_Forward_Public_get_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, 100663490);
			WaypointPath.NativeMethodInfoPtr_get_Reverse_Public_get_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, 100663491);
			WaypointPath.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, 100663492);
			WaypointPath.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, 100663493);
			WaypointPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr, 100663494);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000E7F4 File Offset: 0x0000C9F4
		public unsafe List<Transform> Forward
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointPath.NativeMethodInfoPtr_get_Forward_Public_get_List_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000E834 File Offset: 0x0000CA34
		public unsafe List<Transform> Reverse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointPath.NativeMethodInfoPtr_get_Reverse_Public_get_List_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000E874 File Offset: 0x0000CA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107611, XrefRangeEnd = 1107626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointPath.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000E8A8 File Offset: 0x0000CAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107626, XrefRangeEnd = 1107630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointPath.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000E8DC File Offset: 0x0000CADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107630, XrefRangeEnd = 1107638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaypointPath()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaypointPath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaypointPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002F43 File Offset: 0x00001143
		public WaypointPath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000E918 File Offset: 0x0000CB18
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002F4C File Offset: 0x0000114C
		public unsafe EntityView StartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_StartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_StartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000E948 File Offset: 0x0000CB48
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002F6B File Offset: 0x0000116B
		public unsafe EntityView EndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_EndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_EndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000E978 File Offset: 0x0000CB78
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002F8A File Offset: 0x0000118A
		public unsafe List<Transform> waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000E9A8 File Offset: 0x0000CBA8
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002FA9 File Offset: 0x000011A9
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002FC4 File Offset: 0x000011C4
		public unsafe List<Transform> reversedWaypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_reversedWaypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_reversedWaypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000EA00 File Offset: 0x0000CC00
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002FE3 File Offset: 0x000011E3
		public unsafe WaypointPathProvider waypointProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_waypointProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaypointPathProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaypointPath.NativeFieldInfoPtr_waypointProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_StartPoint;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_EndPoint;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_waypoints;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_reversedWaypoints;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_waypointProvider;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_Forward_Public_get_List_1_Transform_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_get_Reverse_Public_get_List_1_Transform_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
