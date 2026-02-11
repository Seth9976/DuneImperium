using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B6 RID: 182
	public class DropdownMenuEventInfo : Object
	{
		// Token: 0x06001109 RID: 4361 RVA: 0x00058F48 File Offset: 0x00057148
		// Note: this type is marked as 'beforefieldinit'.
		static DropdownMenuEventInfo()
		{
			Il2CppClassPointerStore<DropdownMenuEventInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DropdownMenuEventInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownMenuEventInfo>.NativeClassPtr);
			DropdownMenuEventInfo.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuEventInfo>.NativeClassPtr, "<modifiers>k__BackingField");
			DropdownMenuEventInfo.NativeFieldInfoPtr__mousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuEventInfo>.NativeClassPtr, "<mousePosition>k__BackingField");
			DropdownMenuEventInfo.NativeFieldInfoPtr__localMousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuEventInfo>.NativeClassPtr, "<localMousePosition>k__BackingField");
			DropdownMenuEventInfo.NativeFieldInfoPtr__character_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuEventInfo>.NativeClassPtr, "<character>k__BackingField");
			DropdownMenuEventInfo.NativeFieldInfoPtr__keyCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuEventInfo>.NativeClassPtr, "<keyCode>k__BackingField");
			DropdownMenuEventInfo.NativeMethodInfoPtr__ctor_Public_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenuEventInfo>.NativeClassPtr, 100665727);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00058FF0 File Offset: 0x000571F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311420, RefRangeEnd = 311421, XrefRangeStart = 311403, XrefRangeEnd = 311420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownMenuEventInfo(EventBase e)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownMenuEventInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenuEventInfo.NativeMethodInfoPtr__ctor_Public_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0000887D File Offset: 0x00006A7D
		public DropdownMenuEventInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x0005903C File Offset: 0x0005723C
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x00008886 File Offset: 0x00006A86
		public unsafe EventModifiers _modifiers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuEventInfo.NativeFieldInfoPtr__modifiers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuEventInfo.NativeFieldInfoPtr__modifiers_k__BackingField)) = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x00059064 File Offset: 0x00057264
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x000088A1 File Offset: 0x00006AA1
		public unsafe Vector2 _mousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuEventInfo.NativeFieldInfoPtr__mousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuEventInfo.NativeFieldInfoPtr__mousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0005908C File Offset: 0x0005728C
		// (set) Token: 0x06001111 RID: 4369 RVA: 0x000088BC File Offset: 0x00006ABC
		public unsafe Vector2 _localMousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuEventInfo.NativeFieldInfoPtr__localMousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuEventInfo.NativeFieldInfoPtr__localMousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x000590B4 File Offset: 0x000572B4
		// (set) Token: 0x06001113 RID: 4371 RVA: 0x000088D7 File Offset: 0x00006AD7
		public unsafe char _character_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuEventInfo.NativeFieldInfoPtr__character_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuEventInfo.NativeFieldInfoPtr__character_k__BackingField)) = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x000590DC File Offset: 0x000572DC
		// (set) Token: 0x06001115 RID: 4373 RVA: 0x000088F2 File Offset: 0x00006AF2
		public unsafe KeyCode _keyCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuEventInfo.NativeFieldInfoPtr__keyCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuEventInfo.NativeFieldInfoPtr__keyCode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0000890D File Offset: 0x00006B0D
		public EventModifiers modifiers
		{
			get
			{
				return this._modifiers_k__BackingField;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x00008915 File Offset: 0x00006B15
		public Vector2 mousePosition
		{
			get
			{
				return this._mousePosition_k__BackingField;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0000891D File Offset: 0x00006B1D
		public Vector2 localMousePosition
		{
			get
			{
				return this._localMousePosition_k__BackingField;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x00008925 File Offset: 0x00006B25
		public char character
		{
			get
			{
				return this._character_k__BackingField;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0000892D File Offset: 0x00006B2D
		public KeyCode keyCode
		{
			get
			{
				return this._keyCode_k__BackingField;
			}
		}

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr__mousePosition_k__BackingField;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeFieldInfoPtr__localMousePosition_k__BackingField;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeFieldInfoPtr__character_k__BackingField;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr__keyCode_k__BackingField;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventBase_0;
	}
}
