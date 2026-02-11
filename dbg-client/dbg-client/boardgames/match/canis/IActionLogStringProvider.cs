using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.canis
{
	// Token: 0x02000280 RID: 640
	public class IActionLogStringProvider : Il2CppObjectBase
	{
		// Token: 0x06001E05 RID: 7685 RVA: 0x0000FD74 File Offset: 0x0000DF74
		// Note: this type is marked as 'beforefieldinit'.
		static IActionLogStringProvider()
		{
			Il2CppClassPointerStore<IActionLogStringProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.canis", "IActionLogStringProvider");
			IActionLogStringProvider.NativeMethodInfoPtr_GetLogStrings_Public_Abstract_Virtual_New_SortedDictionary_2_Int32_IReadOnlyList_1_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActionLogStringProvider>.NativeClassPtr, 100668219);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00081B14 File Offset: 0x0007FD14
		[CallerCount(0)]
		public unsafe virtual SortedDictionary<int, IReadOnlyList<string>> GetLogStrings(int numLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numLogs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActionLogStringProvider.NativeMethodInfoPtr_GetLogStrings_Public_Abstract_Virtual_New_SortedDictionary_2_Int32_IReadOnlyList_1_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedDictionary<int, IReadOnlyList<string>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0000FDA3 File Offset: 0x0000DFA3
		public IActionLogStringProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_GetLogStrings_Public_Abstract_Virtual_New_SortedDictionary_2_Int32_IReadOnlyList_1_String_Int32_0;
	}
}
