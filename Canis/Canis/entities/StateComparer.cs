using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000C3 RID: 195
	public class StateComparer : Object
	{
		// Token: 0x060008E2 RID: 2274 RVA: 0x0003DE80 File Offset: 0x0003C080
		// Note: this type is marked as 'beforefieldinit'.
		static StateComparer()
		{
			Il2CppClassPointerStore<StateComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "StateComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateComparer>.NativeClassPtr);
			StateComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateComparer>.NativeClassPtr, 100665126);
			StateComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateComparer>.NativeClassPtr, 100665127);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0003DED8 File Offset: 0x0003C0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0003DF30 File Offset: 0x0003C130
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000056FF File Offset: 0x000038FF
		public StateComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Int32_Int32_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
