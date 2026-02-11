using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C4 RID: 196
	public class JTokenEqualityComparer : Object
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x00065F74 File Offset: 0x00064174
		// Note: this type is marked as 'beforefieldinit'.
		static JTokenEqualityComparer()
		{
			Il2CppClassPointerStore<JTokenEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JTokenEqualityComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JTokenEqualityComparer>.NativeClassPtr);
			JTokenEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JToken_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenEqualityComparer>.NativeClassPtr, 100666741);
			JTokenEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenEqualityComparer>.NativeClassPtr, 100666742);
			JTokenEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JTokenEqualityComparer>.NativeClassPtr, 100666743);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00065FE0 File Offset: 0x000641E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761279, XrefRangeEnd = 761283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(JToken x, JToken y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JToken_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00066040 File Offset: 0x00064240
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(JToken obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00066090 File Offset: 0x00064290
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JTokenEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JTokenEqualityComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JTokenEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00007BBE File Offset: 0x00005DBE
		public JTokenEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JToken_JToken_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_JToken_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
