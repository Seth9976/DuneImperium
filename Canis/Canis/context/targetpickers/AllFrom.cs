using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.context.targetpickers
{
	// Token: 0x0200011A RID: 282
	public class AllFrom : TakeFrom
	{
		// Token: 0x06000CD4 RID: 3284 RVA: 0x0000681C File Offset: 0x00004A1C
		// Note: this type is marked as 'beforefieldinit'.
		static AllFrom()
		{
			Il2CppClassPointerStore<AllFrom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "AllFrom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllFrom>.NativeClassPtr);
			AllFrom.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllFrom>.NativeClassPtr, 100666231);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00050A44 File Offset: 0x0004EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575801, XrefRangeEnd = 575802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllFrom(Entity pile, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllFrom.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00006855 File Offset: 0x00004A55
		public AllFrom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0;
	}
}
