using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D2 RID: 210
	public class PathFilter : Object
	{
		// Token: 0x0600133A RID: 4922 RVA: 0x0006A5D8 File Offset: 0x000687D8
		// Note: this type is marked as 'beforefieldinit'.
		static PathFilter()
		{
			Il2CppClassPointerStore<PathFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq.JsonPath", "PathFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathFilter>.NativeClassPtr);
			PathFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Abstract_Virtual_New_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFilter>.NativeClassPtr, 100666961);
			PathFilter.NativeMethodInfoPtr_GetTokenIndex_Protected_Static_JToken_JToken_JsonSelectSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFilter>.NativeClassPtr, 100666962);
			PathFilter.NativeMethodInfoPtr_GetNextScanValue_Protected_Static_JToken_JToken_JToken_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFilter>.NativeClassPtr, 100666963);
			PathFilter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathFilter>.NativeClassPtr, 100666964);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0006A658 File Offset: 0x00068858
		[CallerCount(0)]
		public unsafe virtual IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, JsonSelectSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathFilter.NativeMethodInfoPtr_ExecuteFilter_Public_Abstract_Virtual_New_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0006A6D8 File Offset: 0x000688D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 763246, RefRangeEnd = 763248, XrefRangeStart = 763236, XrefRangeEnd = 763246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken GetTokenIndex(JToken t, JsonSelectSettings settings, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFilter.NativeMethodInfoPtr_GetTokenIndex_Protected_Static_JToken_JToken_JsonSelectSettings_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0006A73C File Offset: 0x0006893C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 763248, RefRangeEnd = 763250, XrefRangeStart = 763248, XrefRangeEnd = 763248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken GetNextScanValue(JToken originalParent, JToken container, JToken value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalParent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFilter.NativeMethodInfoPtr_GetNextScanValue_Protected_Static_JToken_JToken_JToken_JToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0006A7A4 File Offset: 0x000689A4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathFilter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00007EE9 File Offset: 0x000060E9
		public PathFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteFilter_Public_Abstract_Virtual_New_IEnumerable_1_JToken_JToken_IEnumerable_1_JToken_JsonSelectSettings_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenIndex_Protected_Static_JToken_JToken_JsonSelectSettings_Int32_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_GetNextScanValue_Protected_Static_JToken_JToken_JToken_JToken_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
