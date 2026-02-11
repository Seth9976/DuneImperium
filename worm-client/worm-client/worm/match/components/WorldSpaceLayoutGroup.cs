using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001C7 RID: 455
	public class WorldSpaceLayoutGroup : MonoBehaviour
	{
		// Token: 0x060013F0 RID: 5104 RVA: 0x00054B84 File Offset: 0x00052D84
		// Note: this type is marked as 'beforefieldinit'.
		static WorldSpaceLayoutGroup()
		{
			Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WorldSpaceLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr);
			WorldSpaceLayoutGroup.NativeFieldInfoPtr_rowOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr, "rowOffset");
			WorldSpaceLayoutGroup.NativeFieldInfoPtr_colOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr, "colOffset");
			WorldSpaceLayoutGroup.NativeFieldInfoPtr_rowLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr, "rowLength");
			WorldSpaceLayoutGroup.NativeFieldInfoPtr_layoutOnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr, "layoutOnUpdate");
			WorldSpaceLayoutGroup.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr, "center");
			WorldSpaceLayoutGroup.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr, 100666040);
			WorldSpaceLayoutGroup.NativeMethodInfoPtr_Event_Layout_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr, 100666041);
			WorldSpaceLayoutGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr, 100666042);
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00054C54 File Offset: 0x00052E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713574, XrefRangeEnd = 713575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLayoutGroup.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00054C88 File Offset: 0x00052E88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 713601, RefRangeEnd = 713602, XrefRangeStart = 713575, XrefRangeEnd = 713601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Layout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLayoutGroup.NativeMethodInfoPtr_Event_Layout_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00054CBC File Offset: 0x00052EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713602, XrefRangeEnd = 713603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldSpaceLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpaceLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceLayoutGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0000C3A2 File Offset: 0x0000A5A2
		public WorldSpaceLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00054CF8 File Offset: 0x00052EF8
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x0000C3AB File Offset: 0x0000A5AB
		public unsafe Vector3 rowOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLayoutGroup.NativeFieldInfoPtr_rowOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLayoutGroup.NativeFieldInfoPtr_rowOffset)) = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x00054D20 File Offset: 0x00052F20
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x0000C3C6 File Offset: 0x0000A5C6
		public unsafe Vector3 colOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLayoutGroup.NativeFieldInfoPtr_colOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLayoutGroup.NativeFieldInfoPtr_colOffset)) = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00054D48 File Offset: 0x00052F48
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x0000C3E1 File Offset: 0x0000A5E1
		public unsafe int rowLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLayoutGroup.NativeFieldInfoPtr_rowLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLayoutGroup.NativeFieldInfoPtr_rowLength)) = value;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00054D70 File Offset: 0x00052F70
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		public unsafe bool layoutOnUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLayoutGroup.NativeFieldInfoPtr_layoutOnUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLayoutGroup.NativeFieldInfoPtr_layoutOnUpdate)) = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x00054D98 File Offset: 0x00052F98
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x0000C417 File Offset: 0x0000A617
		public unsafe bool center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLayoutGroup.NativeFieldInfoPtr_center);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceLayoutGroup.NativeFieldInfoPtr_center)) = value;
			}
		}

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeFieldInfoPtr_rowOffset;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeFieldInfoPtr_colOffset;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeFieldInfoPtr_rowLength;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeFieldInfoPtr_layoutOnUpdate;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeFieldInfoPtr_center;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_Event_Layout_Public_Void_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
