using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using worm.match.prompts.behaviours;

namespace worm.match.components
{
	// Token: 0x0200021B RID: 539
	public class WormTleilaxBoardEventPassthrough : PlaymatTogglePassthrough<WormTleilaxPromptBehaviour>
	{
		// Token: 0x060017A8 RID: 6056 RVA: 0x0005FD6C File Offset: 0x0005DF6C
		// Note: this type is marked as 'beforefieldinit'.
		static WormTleilaxBoardEventPassthrough()
		{
			Il2CppClassPointerStore<WormTleilaxBoardEventPassthrough>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormTleilaxBoardEventPassthrough");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTleilaxBoardEventPassthrough>.NativeClassPtr);
			WormTleilaxBoardEventPassthrough.NativeFieldInfoPtr_originalLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTleilaxBoardEventPassthrough>.NativeClassPtr, "originalLayer");
			WormTleilaxBoardEventPassthrough.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxBoardEventPassthrough>.NativeClassPtr, 100666585);
			WormTleilaxBoardEventPassthrough.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxBoardEventPassthrough>.NativeClassPtr, 100666586);
			WormTleilaxBoardEventPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxBoardEventPassthrough>.NativeClassPtr, 100666587);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x0005FDEC File Offset: 0x0005DFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717640, XrefRangeEnd = 717647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTleilaxBoardEventPassthrough.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x0005FE28 File Offset: 0x0005E028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717647, XrefRangeEnd = 717656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxBoardEventPassthrough.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0005FE5C File Offset: 0x0005E05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717656, XrefRangeEnd = 717659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTleilaxBoardEventPassthrough()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxBoardEventPassthrough>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxBoardEventPassthrough.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0000E1F7 File Offset: 0x0000C3F7
		public WormTleilaxBoardEventPassthrough(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x0005FE98 File Offset: 0x0005E098
		// (set) Token: 0x060017AE RID: 6062 RVA: 0x0000E200 File Offset: 0x0000C400
		public Nullable<int> originalLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxBoardEventPassthrough.NativeFieldInfoPtr_originalLayer);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTleilaxBoardEventPassthrough.NativeFieldInfoPtr_originalLayer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeFieldInfoPtr_originalLayer;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
