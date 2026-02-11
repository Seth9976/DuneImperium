using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Bindings
{
	// Token: 0x02000016 RID: 22
	public class FreeFunctionAttribute : NativeMethodAttribute
	{
		// Token: 0x06000096 RID: 150 RVA: 0x0000400C File Offset: 0x0000220C
		// Note: this type is marked as 'beforefieldinit'.
		static FreeFunctionAttribute()
		{
			Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "FreeFunctionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr);
			FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr, 100663345);
			FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr, 100663346);
			FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr, 100663347);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004078 File Offset: 0x00002278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269128, XrefRangeEnd = 1269129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeFunctionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000040B4 File Offset: 0x000022B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269129, XrefRangeEnd = 1269130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeFunctionAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004100 File Offset: 0x00002300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269130, XrefRangeEnd = 1269131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeFunctionAttribute(string name, bool isThreadSafe)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThreadSafe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000025B2 File Offset: 0x000007B2
		public FreeFunctionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;
	}
}
