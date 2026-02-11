using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.utils
{
	// Token: 0x0200005E RID: 94
	public static class WormEntityExtensions : Object
	{
		// Token: 0x060003B7 RID: 951 RVA: 0x00024B28 File Offset: 0x00022D28
		// Note: this type is marked as 'beforefieldinit'.
		static WormEntityExtensions()
		{
			Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.utils", "WormEntityExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr);
			WormEntityExtensions.NativeMethodInfoPtr_IsHandPlayable_Public_Static_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100663914);
			WormEntityExtensions.NativeMethodInfoPtr_IsCardPlayable_Public_Static_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityExtensions>.NativeClassPtr, 100663915);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00024B80 File Offset: 0x00022D80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 693654, RefRangeEnd = 693657, XrefRangeStart = 693647, XrefRangeEnd = 693654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHandPlayable(this EntityComponent entity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_IsHandPlayable_Public_Static_Boolean_EntityComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00024BC4 File Offset: 0x00022DC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 693673, RefRangeEnd = 693676, XrefRangeStart = 693657, XrefRangeEnd = 693673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCardPlayable(this EntityComponent entity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityExtensions.NativeMethodInfoPtr_IsCardPlayable_Public_Static_Boolean_EntityComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00003A1D File Offset: 0x00001C1D
		public WormEntityExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_IsHandPlayable_Public_Static_Boolean_EntityComponent_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_IsCardPlayable_Public_Static_Boolean_EntityComponent_0;
	}
}
