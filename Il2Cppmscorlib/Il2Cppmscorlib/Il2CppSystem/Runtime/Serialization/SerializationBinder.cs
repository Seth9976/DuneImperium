using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000321 RID: 801
	[Serializable]
	public class SerializationBinder : Object
	{
		// Token: 0x060030DD RID: 12509 RVA: 0x000F8C70 File Offset: 0x000F6E70
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationBinder()
		{
			Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr);
			SerializationBinder.NativeMethodInfoPtr_BindToName_Public_Virtual_New_Void_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr, 100670989);
			SerializationBinder.NativeMethodInfoPtr_BindToType_Public_Abstract_Virtual_New_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr, 100670990);
			SerializationBinder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr, 100670991);
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x000F8CDC File Offset: 0x000F6EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384631, XrefRangeEnd = 1384633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BindToName(Type serializedType, out string assemblyName, out string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializationBinder.NativeMethodInfoPtr_BindToName_Public_Virtual_New_Void_Type_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			assemblyName = IL2CPP.Il2CppStringToManaged(intPtr);
			typeName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x000F8D60 File Offset: 0x000F6F60
		[CallerCount(0)]
		public unsafe virtual Type BindToType(string assemblyName, string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializationBinder.NativeMethodInfoPtr_BindToType_Public_Abstract_Virtual_New_Type_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x000F8DD0 File Offset: 0x000F6FD0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationBinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationBinder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationBinder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x00010D1C File Offset: 0x0000EF1C
		public SerializationBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002847 RID: 10311
		private static readonly IntPtr NativeMethodInfoPtr_BindToName_Public_Virtual_New_Void_Type_byref_String_byref_String_0;

		// Token: 0x04002848 RID: 10312
		private static readonly IntPtr NativeMethodInfoPtr_BindToType_Public_Abstract_Virtual_New_Type_String_String_0;

		// Token: 0x04002849 RID: 10313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
