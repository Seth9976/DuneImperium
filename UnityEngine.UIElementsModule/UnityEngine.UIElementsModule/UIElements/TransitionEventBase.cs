using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000125 RID: 293
	public class TransitionEventBase<T> : EventBase<T> where T : TransitionEventBase<T>, new()
	{
		// Token: 0x06001605 RID: 5637 RVA: 0x0006AF08 File Offset: 0x00069108
		// Note: this type is marked as 'beforefieldinit'.
		static TransitionEventBase()
		{
			Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TransitionEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr);
			TransitionEventBase<T>.NativeFieldInfoPtr__stylePropertyNames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr, "<stylePropertyNames>k__BackingField");
			TransitionEventBase<T>.NativeFieldInfoPtr__elapsedTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr, "<elapsedTime>k__BackingField");
			TransitionEventBase<T>.NativeMethodInfoPtr_get_stylePropertyNames_Public_Virtual_Final_New_get_StylePropertyNameCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr, 100666575);
			TransitionEventBase<T>.NativeMethodInfoPtr_set_elapsedTime_Protected_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr, 100666576);
			TransitionEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr, 100666577);
			TransitionEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr, 100666578);
			TransitionEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr, 100666579);
			TransitionEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_StylePropertyName_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr, 100666580);
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x0006B014 File Offset: 0x00069214
		public unsafe virtual StylePropertyNameCollection stylePropertyNames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionEventBase<T>.NativeMethodInfoPtr_get_stylePropertyNames_Public_Virtual_Final_New_get_StylePropertyNameCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StylePropertyNameCollection(intPtr);
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x0000A427 File Offset: 0x00008627
		// (set) Token: 0x06001607 RID: 5639 RVA: 0x0006B04C File Offset: 0x0006924C
		public unsafe double elapsedTime
		{
			get
			{
				return this._elapsedTime_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionEventBase<T>.NativeMethodInfoPtr_set_elapsedTime_Protected_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0006B08C File Offset: 0x0006928C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 317227, RefRangeEnd = 317235, XrefRangeStart = 317213, XrefRangeEnd = 317227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitionEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitionEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0006B0C8 File Offset: 0x000692C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317235, XrefRangeEnd = 317239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitionEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0006B104 File Offset: 0x00069304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317239, XrefRangeEnd = 317242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x0006B138 File Offset: 0x00069338
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 317254, RefRangeEnd = 317258, XrefRangeStart = 317242, XrefRangeEnd = 317254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(stylePropertyName));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitionEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_StylePropertyName_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0000A3D5 File Offset: 0x000085D5
		public TransitionEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x0006B18C File Offset: 0x0006938C
		// (set) Token: 0x0600160E RID: 5646 RVA: 0x0000A3DE File Offset: 0x000085DE
		public StylePropertyNameCollection _stylePropertyNames_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionEventBase<T>.NativeFieldInfoPtr__stylePropertyNames_k__BackingField);
				return new StylePropertyNameCollection(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionEventBase<T>.NativeFieldInfoPtr__stylePropertyNames_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x0006B1BC File Offset: 0x000693BC
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x0000A40C File Offset: 0x0000860C
		public unsafe double _elapsedTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionEventBase<T>.NativeFieldInfoPtr__elapsedTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitionEventBase<T>.NativeFieldInfoPtr__elapsedTime_k__BackingField)) = value;
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0006B1E4 File Offset: 0x000693E4
		public bool AffectsProperty(StylePropertyName stylePropertyName)
		{
			StylePropertyNameCollection stylePropertyNames = this.stylePropertyNames;
			return stylePropertyNames.Contains(stylePropertyName);
		}

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeFieldInfoPtr__stylePropertyNames_k__BackingField;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_k__BackingField;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_get_stylePropertyNames_Public_Virtual_Final_New_get_StylePropertyNameCollection_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_set_elapsedTime_Protected_set_Void_Double_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_StylePropertyName_Double_0;
	}
}
