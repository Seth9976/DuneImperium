using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001DA RID: 474
	public class Comparer : Object
	{
		// Token: 0x06001D6D RID: 7533 RVA: 0x0008E57C File Offset: 0x0008C77C
		// Note: this type is marked as 'beforefieldinit'.
		static Comparer()
		{
			Il2CppClassPointerStore<Comparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Comparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Comparer>.NativeClassPtr);
			Comparer.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100667799);
			Comparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100667800);
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0008E5D4 File Offset: 0x0008C7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477065, XrefRangeEnd = 477070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IComparer_Compare(Object ol, Object or)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ol);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0008E634 File Offset: 0x0008C834
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0000C88F File Offset: 0x0000AA8F
		public Comparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
