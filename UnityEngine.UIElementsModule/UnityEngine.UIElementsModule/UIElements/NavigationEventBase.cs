using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000107 RID: 263
	public class NavigationEventBase<T> : EventBase<T> where T : NavigationEventBase<T>, new()
	{
		// Token: 0x06001483 RID: 5251 RVA: 0x000658C8 File Offset: 0x00063AC8
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationEventBase()
		{
			Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "NavigationEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr);
			NavigationEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, "<modifiers>k__BackingField");
			NavigationEventBase<T>.NativeFieldInfoPtr__deviceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, "<deviceType>k__BackingField");
			NavigationEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666285);
			NavigationEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666286);
			NavigationEventBase<T>.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666287);
			NavigationEventBase<T>.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666288);
			NavigationEventBase<T>.NativeMethodInfoPtr_get_deviceType_Internal_get_NavigationDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666289);
			NavigationEventBase<T>.NativeMethodInfoPtr_set_deviceType_Private_set_Void_NavigationDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666290);
			NavigationEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666291);
			NavigationEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666292);
			NavigationEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666293);
			NavigationEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666294);
			NavigationEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_NavigationDeviceType_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr, 100666295);
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x00065A38 File Offset: 0x00063C38
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x00065A74 File Offset: 0x00063C74
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x00065AB4 File Offset: 0x00063CB4
		public unsafe virtual bool shiftKey
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 314188, RefRangeEnd = 314194, XrefRangeStart = 314188, XrefRangeEnd = 314194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x00065AF0 File Offset: 0x00063CF0
		public unsafe virtual bool altKey
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 314198, RefRangeEnd = 314202, XrefRangeStart = 314198, XrefRangeEnd = 314202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x00065B2C File Offset: 0x00063D2C
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x00065B68 File Offset: 0x00063D68
		public unsafe NavigationDeviceType deviceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr_get_deviceType_Internal_get_NavigationDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr_set_deviceType_Private_set_Void_NavigationDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00065BA8 File Offset: 0x00063DA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315465, RefRangeEnd = 315471, XrefRangeStart = 315461, XrefRangeEnd = 315465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00065BE4 File Offset: 0x00063DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315473, RefRangeEnd = 315474, XrefRangeStart = 315471, XrefRangeEnd = 315473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NavigationEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00065C20 File Offset: 0x00063E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315474, XrefRangeEnd = 315475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00065C54 File Offset: 0x00063E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315482, RefRangeEnd = 315484, XrefRangeStart = 315475, XrefRangeEnd = 315482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(EventModifiers modifiers = EventModifiers.None)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref modifiers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00065C90 File Offset: 0x00063E90
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 315491, RefRangeEnd = 315499, XrefRangeStart = 315484, XrefRangeEnd = 315491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = EventModifiers.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_NavigationDeviceType_EventModifiers_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00009BF3 File Offset: 0x00007DF3
		public NavigationEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x00065CD8 File Offset: 0x00063ED8
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x00009BFC File Offset: 0x00007DFC
		public unsafe EventModifiers _modifiers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField)) = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x00065D00 File Offset: 0x00063F00
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x00009C17 File Offset: 0x00007E17
		public unsafe NavigationDeviceType _deviceType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationEventBase<T>.NativeFieldInfoPtr__deviceType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationEventBase<T>.NativeFieldInfoPtr__deviceType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x00065D28 File Offset: 0x00063F28
		public bool ctrlKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Control) > EventModifiers.None;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00065D48 File Offset: 0x00063F48
		public bool commandKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Command) > EventModifiers.None;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x00065D68 File Offset: 0x00063F68
		public bool actionKey
		{
			get
			{
				bool flag = Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer;
				bool flag2;
				if (flag)
				{
					flag2 = this.commandKey;
				}
				else
				{
					flag2 = this.ctrlKey;
				}
				return flag2;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x00009C32 File Offset: 0x00007E32
		public NavigationDeviceType UnityEngine.UIElements.INavigationEvent.deviceType
		{
			get
			{
				return this.deviceType;
			}
		}

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeFieldInfoPtr__deviceType_k__BackingField;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceType_Internal_get_NavigationDeviceType_0;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_set_deviceType_Private_set_Void_NavigationDeviceType_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_EventModifiers_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_T_NavigationDeviceType_EventModifiers_0;
	}
}
