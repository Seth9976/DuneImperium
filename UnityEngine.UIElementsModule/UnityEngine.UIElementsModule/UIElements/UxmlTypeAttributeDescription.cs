using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001FF RID: 511
	public class UxmlTypeAttributeDescription<TBase> : TypedUxmlAttributeDescription<Type>
	{
		// Token: 0x060027D4 RID: 10196 RVA: 0x000AF418 File Offset: 0x000AD618
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlTypeAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlTypeAttributeDescription<TBase>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlTypeAttributeDescription`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBase>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlTypeAttributeDescription<TBase>>.NativeClassPtr);
			UxmlTypeAttributeDescription<TBase>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTypeAttributeDescription<TBase>>.NativeClassPtr, 100669295);
			UxmlTypeAttributeDescription<TBase>.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Type_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTypeAttributeDescription<TBase>>.NativeClassPtr, 100669296);
			UxmlTypeAttributeDescription<TBase>.NativeMethodInfoPtr_ConvertValueToType_Private_Type_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTypeAttributeDescription<TBase>>.NativeClassPtr, 100669297);
			UxmlTypeAttributeDescription<TBase>.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Private_Type_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlTypeAttributeDescription<TBase>>.NativeClassPtr, 100669298);
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x000AF4D4 File Offset: 0x000AD6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343723, XrefRangeEnd = 343739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlTypeAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlTypeAttributeDescription<TBase>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlTypeAttributeDescription<TBase>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x000AF510 File Offset: 0x000AD710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343739, XrefRangeEnd = 343747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlTypeAttributeDescription<TBase>.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Type_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x000AF584 File Offset: 0x000AD784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343782, RefRangeEnd = 343783, XrefRangeStart = 343747, XrefRangeEnd = 343782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type ConvertValueToType(string v, Type defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlTypeAttributeDescription<TBase>.NativeMethodInfoPtr_ConvertValueToType_Private_Type_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000AF5E8 File Offset: 0x000AD7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343783, XrefRangeEnd = 343796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type _GetValueFromBag_b__3_0(string s, Type type1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlTypeAttributeDescription<TBase>.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Private_Type_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x0001022F File Offset: 0x0000E42F
		public UxmlTypeAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x000AF64C File Offset: 0x000AD84C
		public override string defaultValueAsString
		{
			get
			{
				return (base.defaultValue == null) ? "null" : base.defaultValue.FullName;
			}
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x000AF680 File Offset: 0x000AD880
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref Type value)
		{
			return base.TryGetValueFromBag<Type>(bag, cc, new Func<string, Type, Type>(this.<TryGetValueFromBag>b__4_0), base.defaultValue, ref value);
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00010238 File Offset: 0x0000E438
		public Type <TryGetValueFromBag>b__4_0(string s, Type type1)
		{
			return this.ConvertValueToType(s, type1);
		}

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Type_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValueToType_Private_Type_String_Type_0;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Private_Type_String_Type_0;
	}
}
