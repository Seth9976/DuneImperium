using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E9 RID: 233
	public class InputEvent : EventBase<InputEvent>
	{
		// Token: 0x0600136A RID: 4970 RVA: 0x0006132C File Offset: 0x0005F52C
		// Note: this type is marked as 'beforefieldinit'.
		static InputEvent()
		{
			Il2CppClassPointerStore<InputEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "InputEvent");
			InputEvent.NativeFieldInfoPtr__previousData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, "<previousData>k__BackingField");
			InputEvent.NativeFieldInfoPtr__newData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, "<newData>k__BackingField");
			InputEvent.NativeMethodInfoPtr_set_previousData_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100666052);
			InputEvent.NativeMethodInfoPtr_set_newData_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100666053);
			InputEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100666054);
			InputEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100666055);
			InputEvent.NativeMethodInfoPtr_GetPooled_Public_Static_InputEvent_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100666056);
			InputEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100666057);
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x000097FF File Offset: 0x000079FF
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x000613F4 File Offset: 0x0005F5F4
		public unsafe string previousData
		{
			get
			{
				return this._previousData_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputEvent.NativeMethodInfoPtr_set_previousData_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x00009807 File Offset: 0x00007A07
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x00061438 File Offset: 0x0005F638
		public unsafe string newData
		{
			get
			{
				return this._newData_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputEvent.NativeMethodInfoPtr_set_newData_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0006147C File Offset: 0x0005F67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314132, XrefRangeEnd = 314137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x000614B8 File Offset: 0x0005F6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314137, XrefRangeEnd = 314155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x000614EC File Offset: 0x0005F6EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314163, RefRangeEnd = 314164, XrefRangeStart = 314155, XrefRangeEnd = 314163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InputEvent GetPooled(string previousData, string newData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(previousData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputEvent.NativeMethodInfoPtr_GetPooled_Public_Static_InputEvent_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputEvent>(intPtr3) : null;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00061544 File Offset: 0x0005F744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314164, XrefRangeEnd = 314172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x000097B8 File Offset: 0x000079B8
		public InputEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x00061580 File Offset: 0x0005F780
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x000097C1 File Offset: 0x000079C1
		public unsafe string _previousData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputEvent.NativeFieldInfoPtr__previousData_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputEvent.NativeFieldInfoPtr__previousData_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x000615A8 File Offset: 0x0005F7A8
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x000097E0 File Offset: 0x000079E0
		public unsafe string _newData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputEvent.NativeFieldInfoPtr__newData_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputEvent.NativeFieldInfoPtr__newData_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeFieldInfoPtr__previousData_k__BackingField;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeFieldInfoPtr__newData_k__BackingField;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_set_previousData_Protected_set_Void_String_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_set_newData_Protected_set_Void_String_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_InputEvent_String_String_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200040F RID: 1039
		[ObfuscatedName("UnityEngine.UIElements.InputEvent+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003ADD RID: 15069 RVA: 0x000EDED0 File Offset: 0x000EC0D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InputEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputEvent.__c>.NativeClassPtr);
				InputEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEvent.__c>.NativeClassPtr, "<>9");
				InputEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent.__c>.NativeClassPtr, 100666059);
				InputEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_InputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent.__c>.NativeClassPtr, 100666060);
			}

			// Token: 0x06003ADE RID: 15070 RVA: 0x000EDF38 File Offset: 0x000EC138
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003ADF RID: 15071 RVA: 0x000EDF74 File Offset: 0x000EC174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314121, XrefRangeEnd = 314132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputEvent __cctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputEvent.__c.NativeMethodInfoPtr___cctor_b__0_0_Internal_InputEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputEvent>(intPtr3) : null;
			}

			// Token: 0x06003AE0 RID: 15072 RVA: 0x00018D1B File Offset: 0x00016F1B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001200 RID: 4608
			// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x000EDFB4 File Offset: 0x000EC1B4
			// (set) Token: 0x06003AE2 RID: 15074 RVA: 0x00018D24 File Offset: 0x00016F24
			public unsafe static InputEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InputEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InputEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040029A0 RID: 10656
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040029A1 RID: 10657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040029A2 RID: 10658
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__0_0_Internal_InputEvent_0;
		}

		// Token: 0x02000410 RID: 1040
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
