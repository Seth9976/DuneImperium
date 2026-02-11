using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000019 RID: 25
	public class PropertyBag<TContainer> : Object
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00005BAC File Offset: 0x00003DAC
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyBag()
		{
			Il2CppClassPointerStore<PropertyBag<TContainer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "PropertyBag`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) })).TypeHandle.value);
			PropertyBag<TContainer>.NativeFieldInfoPtr__InstantiationKind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyBag<TContainer>>.NativeClassPtr, "<InstantiationKind>k__BackingField");
			PropertyBag<TContainer>.NativeMethodInfoPtr_Unity_Properties_Internal_IPropertyBagRegister_Register_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBag<TContainer>>.NativeClassPtr, 100663373);
			PropertyBag<TContainer>.NativeMethodInfoPtr_Accept_Public_Virtual_Final_New_Void_ITypeVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBag<TContainer>>.NativeClassPtr, 100663374);
			PropertyBag<TContainer>.NativeMethodInfoPtr_Unity_Properties_IConstructor_get_InstantiationKind_Private_Virtual_Final_New_get_InstantiationKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBag<TContainer>>.NativeClassPtr, 100663375);
			PropertyBag<TContainer>.NativeMethodInfoPtr_Unity_Properties_IConstructor_TContainer__Instantiate_Private_Virtual_Final_New_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBag<TContainer>>.NativeClassPtr, 100663376);
			PropertyBag<TContainer>.NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_New_get_InstantiationKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBag<TContainer>>.NativeClassPtr, 100663377);
			PropertyBag<TContainer>.NativeMethodInfoPtr_Instantiate_Protected_Virtual_New_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBag<TContainer>>.NativeClassPtr, 100663378);
			PropertyBag<TContainer>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBag<TContainer>>.NativeClassPtr, 100663379);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005CB0 File Offset: 0x00003EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230874, XrefRangeEnd = 1230915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unity_Properties_Internal_IPropertyBagRegister_Register()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyBag<TContainer>.NativeMethodInfoPtr_Unity_Properties_Internal_IPropertyBagRegister_Register_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005CE4 File Offset: 0x00003EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230915, XrefRangeEnd = 1230921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Accept(ITypeVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyBag<TContainer>.NativeMethodInfoPtr_Accept_Public_Virtual_Final_New_Void_ITypeVisitor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00005D28 File Offset: 0x00003F28
		public unsafe virtual InstantiationKind Unity.Properties.IConstructor.InstantiationKind
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 381934, RefRangeEnd = 381975, XrefRangeStart = 381934, XrefRangeEnd = 381975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyBag<TContainer>.NativeMethodInfoPtr_Unity_Properties_IConstructor_get_InstantiationKind_Private_Virtual_Final_New_get_InstantiationKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005D64 File Offset: 0x00003F64
		[CallerCount(0)]
		public unsafe virtual TContainer Unity_Properties_IConstructor_TContainer__Instantiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyBag<TContainer>.NativeMethodInfoPtr_Unity_Properties_IConstructor_TContainer__Instantiate_Private_Virtual_Final_New_TContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TContainer>(intPtr, false, true);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00005DA0 File Offset: 0x00003FA0
		public unsafe virtual InstantiationKind InstantiationKind
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyBag<TContainer>.NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_New_get_InstantiationKind_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005DE8 File Offset: 0x00003FE8
		[CallerCount(0)]
		public unsafe virtual TContainer Instantiate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyBag<TContainer>.NativeMethodInfoPtr_Instantiate_Protected_Virtual_New_TContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TContainer>(intPtr, false, true);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005E2C File Offset: 0x0000402C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230922, RefRangeEnd = 1230923, XrefRangeStart = 1230921, XrefRangeEnd = 1230922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyBag<TContainer>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyBag<TContainer>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002611 File Offset: 0x00000811
		public PropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00005E68 File Offset: 0x00004068
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000261A File Offset: 0x0000081A
		public unsafe InstantiationKind _InstantiationKind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyBag<TContainer>.NativeFieldInfoPtr__InstantiationKind_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyBag<TContainer>.NativeFieldInfoPtr__InstantiationKind_k__BackingField)) = value;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005E90 File Offset: 0x00004090
		public void Unity.Properties.IPropertyBag.Accept(IPropertyBagVisitor visitor, ref Object container)
		{
			bool flag = container == null;
			if (flag)
			{
				throw new ArgumentNullException("container");
			}
			Object @object = container;
			TContainer tcontainer;
			int num;
			if (@object.TryCast<TContainer>() != null)
			{
				tcontainer = @object.Cast<TContainer>();
				num = 1;
			}
			else
			{
				num = 0;
			}
			bool flag2 = num == 0;
			if (flag2)
			{
				throw new ArgumentException(String.Format("The given ContainerType=[{0}] does not match the PropertyBagType=[{1}]", container.GetType(), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TContainer>())));
			}
			PropertyBag.AcceptWithSpecializedVisitor<TContainer>(this, visitor, ref tcontainer);
			container = tcontainer;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002635 File Offset: 0x00000835
		public void Unity.Properties.IPropertyBag<TContainer>.Accept(IPropertyBagVisitor visitor, ref TContainer container)
		{
			visitor.Visit<TContainer>(this, ref container);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002641 File Offset: 0x00000841
		public TContainer CreateInstance()
		{
			return TypeUtility.Instantiate<TContainer>();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002648 File Offset: 0x00000848
		public bool TryCreateInstance(out TContainer instance)
		{
			return TypeUtility.TryInstantiate<TContainer>(out instance);
		}

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr__InstantiationKind_k__BackingField;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Unity_Properties_Internal_IPropertyBagRegister_Register_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Public_Virtual_Final_New_Void_ITypeVisitor_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Unity_Properties_IConstructor_get_InstantiationKind_Private_Virtual_Final_New_get_InstantiationKind_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Unity_Properties_IConstructor_TContainer__Instantiate_Private_Virtual_Final_New_TContainer_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_InstantiationKind_Protected_Virtual_New_get_InstantiationKind_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Protected_Virtual_New_TContainer_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
