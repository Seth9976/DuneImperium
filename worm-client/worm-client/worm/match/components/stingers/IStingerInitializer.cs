using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace worm.match.components.stingers
{
	// Token: 0x02000225 RID: 549
	public class IStingerInitializer : Il2CppObjectBase
	{
		// Token: 0x06001809 RID: 6153 RVA: 0x000610AC File Offset: 0x0005F2AC
		// Note: this type is marked as 'beforefieldinit'.
		static IStingerInitializer()
		{
			Il2CppClassPointerStore<IStingerInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "IStingerInitializer");
			IStingerInitializer.NativeMethodInfoPtr_InitViews_Public_Abstract_Virtual_New_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStingerInitializer>.NativeClassPtr, 100666630);
			IStingerInitializer.NativeMethodInfoPtr_ResetViews_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStingerInitializer>.NativeClassPtr, 100666631);
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000610FC File Offset: 0x0005F2FC
		[CallerCount(0)]
		public unsafe virtual void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStingerInitializer.NativeMethodInfoPtr_InitViews_Public_Abstract_Virtual_New_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x0006114C File Offset: 0x0005F34C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStingerInitializer.NativeMethodInfoPtr_ResetViews_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x0000E4A5 File Offset: 0x0000C6A5
		public IStingerInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Abstract_Virtual_New_Void_IHasAttributes_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_ResetViews_Public_Virtual_New_Void_0;
	}
}
