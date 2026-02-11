using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Unity.Properties
{
	// Token: 0x0200000F RID: 15
	public class ContainerPropertyBag<TContainer> : PropertyBag<TContainer>
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00004CBC File Offset: 0x00002EBC
		// Note: this type is marked as 'beforefieldinit'.
		static ContainerPropertyBag()
		{
			Il2CppClassPointerStore<ContainerPropertyBag<TContainer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "ContainerPropertyBag`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) })).TypeHandle.value);
			ContainerPropertyBag<TContainer>.NativeFieldInfoPtr_m_PropertiesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerPropertyBag<TContainer>>.NativeClassPtr, "m_PropertiesList");
			ContainerPropertyBag<TContainer>.NativeFieldInfoPtr_m_PropertiesHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerPropertyBag<TContainer>>.NativeClassPtr, "m_PropertiesHash");
			ContainerPropertyBag<TContainer>.NativeMethodInfoPtr_AddProperty_Protected_Void_Property_2_TContainer_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerPropertyBag<TContainer>>.NativeClassPtr, 100663341);
			ContainerPropertyBag<TContainer>.NativeMethodInfoPtr_TryGetProperty_Public_Virtual_Final_New_Boolean_byref_TContainer_String_byref_IProperty_1_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerPropertyBag<TContainer>>.NativeClassPtr, 100663342);
			ContainerPropertyBag<TContainer>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerPropertyBag<TContainer>>.NativeClassPtr, 100663343);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004D84 File Offset: 0x00002F84
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 1230687, RefRangeEnd = 1230751, XrefRangeStart = 1230671, XrefRangeEnd = 1230687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddProperty<TValue>(Property<TContainer, TValue> property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerPropertyBag<TValue>.MethodInfoStoreGeneric_AddProperty_Protected_Void_Property_2_TContainer_TValue_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004DC8 File Offset: 0x00002FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230751, XrefRangeEnd = 1230753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(container);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ContainerPropertyBag<TContainer>.NativeMethodInfoPtr_TryGetProperty_Public_Virtual_Final_New_Boolean_byref_TContainer_String_byref_IProperty_1_TContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			container = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TContainer>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			property = ((intPtr6 == 0) ? null : new IProperty<TContainer>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004E64 File Offset: 0x00003064
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1230772, RefRangeEnd = 1230793, XrefRangeStart = 1230753, XrefRangeEnd = 1230772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContainerPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerPropertyBag<TContainer>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerPropertyBag<TContainer>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000023EE File Offset: 0x000005EE
		public ContainerPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004EA0 File Offset: 0x000030A0
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000023F7 File Offset: 0x000005F7
		public unsafe List<IProperty<TContainer>> m_PropertiesList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerPropertyBag<TContainer>.NativeFieldInfoPtr_m_PropertiesList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IProperty<TContainer>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerPropertyBag<TContainer>.NativeFieldInfoPtr_m_PropertiesList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004ED0 File Offset: 0x000030D0
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002416 File Offset: 0x00000616
		public unsafe Dictionary<string, IProperty<TContainer>> m_PropertiesHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerPropertyBag<TContainer>.NativeFieldInfoPtr_m_PropertiesHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IProperty<TContainer>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerPropertyBag<TContainer>.NativeFieldInfoPtr_m_PropertiesHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertiesList;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertiesHash;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_AddProperty_Protected_Void_Property_2_TContainer_TValue_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_TryGetProperty_Public_Virtual_Final_New_Boolean_byref_TContainer_String_byref_IProperty_1_TContainer_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000060 RID: 96
		private sealed class MethodInfoStoreGeneric_AddProperty_Protected_Void_Property_2_TContainer_TValue_0
		{
			// Token: 0x040000EF RID: 239
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ContainerPropertyBag<TValue>.NativeMethodInfoPtr_AddProperty_Protected_Void_Property_2_TContainer_TValue_0, Il2CppClassPointerStore<ContainerPropertyBag<TValue>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
		}
	}
}
