using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020002A8 RID: 680
	[Serializable]
	public class TypeInfo : Object
	{
		// Token: 0x06002BA7 RID: 11175 RVA: 0x000E64A0 File Offset: 0x000E46A0
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInfo()
		{
			Il2CppClassPointerStore<TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "TypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr);
			TypeInfo.NativeFieldInfoPtr_serverType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, "serverType");
			TypeInfo.NativeFieldInfoPtr_serverHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, "serverHierarchy");
			TypeInfo.NativeFieldInfoPtr_interfacesImplemented = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, "interfacesImplemented");
			TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100670365);
			TypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100670366);
			TypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100670367);
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000E6548 File Offset: 0x000E4748
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1379530, RefRangeEnd = 1379532, XrefRangeStart = 1379492, XrefRangeEnd = 1379530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInfo(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000E6594 File Offset: 0x000E4794
		public unsafe virtual string TypeName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x000E65CC File Offset: 0x000E47CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379532, XrefRangeEnd = 1379564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanCastTo(Type fromType, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x0000E8AB File Offset: 0x0000CAAB
		public TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x000E662C File Offset: 0x000E482C
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x0000E8B4 File Offset: 0x0000CAB4
		public unsafe string serverType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x000E6654 File Offset: 0x000E4854
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x0000E8D3 File Offset: 0x0000CAD3
		public unsafe Il2CppStringArray serverHierarchy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverHierarchy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverHierarchy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x000E6684 File Offset: 0x000E4884
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x0000E8F2 File Offset: 0x0000CAF2
		public unsafe Il2CppStringArray interfacesImplemented
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_interfacesImplemented);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_interfacesImplemented), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024F0 RID: 9456
		private static readonly IntPtr NativeFieldInfoPtr_serverType;

		// Token: 0x040024F1 RID: 9457
		private static readonly IntPtr NativeFieldInfoPtr_serverHierarchy;

		// Token: 0x040024F2 RID: 9458
		private static readonly IntPtr NativeFieldInfoPtr_interfacesImplemented;

		// Token: 0x040024F3 RID: 9459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x040024F4 RID: 9460
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040024F5 RID: 9461
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0;
	}
}
