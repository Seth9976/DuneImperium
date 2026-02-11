using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000434 RID: 1076
	public class TypeInfo : Type
	{
		// Token: 0x06003DEA RID: 15850 RVA: 0x0012934C File Offset: 0x0012754C
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInfo()
		{
			Il2CppClassPointerStore<TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "TypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr);
			TypeInfo.NativeFieldInfoPtr_DeclaredOnlyLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, "DeclaredOnlyLookup");
			TypeInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100672613);
			TypeInfo.NativeMethodInfoPtr_System_Reflection_IReflectableType_GetTypeInfo_Private_Virtual_Final_New_TypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100672614);
			TypeInfo.NativeMethodInfoPtr_get_DeclaredMethods_Public_Virtual_New_get_IEnumerable_1_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100672615);
			TypeInfo.NativeMethodInfoPtr_get_ImplementedInterfaces_Public_Virtual_New_get_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100672616);
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x001293E0 File Offset: 0x001275E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1399696, RefRangeEnd = 1399697, XrefRangeStart = 1399692, XrefRangeEnd = 1399696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x0012941C File Offset: 0x0012761C
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeInfo System_Reflection_IReflectableType_GetTypeInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr_System_Reflection_IReflectableType_GetTypeInfo_Private_Virtual_Final_New_TypeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInfo>(intPtr3) : null;
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06003DED RID: 15853 RVA: 0x0012945C File Offset: 0x0012765C
		public unsafe virtual IEnumerable<MethodInfo> DeclaredMethods
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeInfo.NativeMethodInfoPtr_get_DeclaredMethods_Public_Virtual_New_get_IEnumerable_1_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06003DEE RID: 15854 RVA: 0x001294A8 File Offset: 0x001276A8
		public unsafe virtual IEnumerable<Type> ImplementedInterfaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeInfo.NativeMethodInfoPtr_get_ImplementedInterfaces_Public_Virtual_New_get_IEnumerable_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x000169EB File Offset: 0x00014BEB
		public TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x001294F4 File Offset: 0x001276F4
		// (set) Token: 0x06003DF1 RID: 15857 RVA: 0x000169F4 File Offset: 0x00014BF4
		public unsafe static BindingFlags DeclaredOnlyLookup
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(TypeInfo.NativeFieldInfoPtr_DeclaredOnlyLookup, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeInfo.NativeFieldInfoPtr_DeclaredOnlyLookup, (void*)(&value));
			}
		}

		// Token: 0x040032B6 RID: 12982
		private static readonly IntPtr NativeFieldInfoPtr_DeclaredOnlyLookup;

		// Token: 0x040032B7 RID: 12983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040032B8 RID: 12984
		private static readonly IntPtr NativeMethodInfoPtr_System_Reflection_IReflectableType_GetTypeInfo_Private_Virtual_Final_New_TypeInfo_0;

		// Token: 0x040032B9 RID: 12985
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaredMethods_Public_Virtual_New_get_IEnumerable_1_MethodInfo_0;

		// Token: 0x040032BA RID: 12986
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementedInterfaces_Public_Virtual_New_get_IEnumerable_1_Type_0;
	}
}
