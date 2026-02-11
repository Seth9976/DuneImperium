using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

namespace zen.src.match.monobehaviours.renderers
{
	// Token: 0x02000007 RID: 7
	public class RegisterEntityView : ObserveOnce
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00009A14 File Offset: 0x00007C14
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterEntityView()
		{
			Il2CppClassPointerStore<RegisterEntityView>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "zen.src.match.monobehaviours.renderers", "RegisterEntityView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterEntityView>.NativeClassPtr);
			RegisterEntityView.NativeFieldInfoPtr_viewLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEntityView>.NativeClassPtr, "viewLayer");
			RegisterEntityView.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEntityView>.NativeClassPtr, 100663313);
			RegisterEntityView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEntityView>.NativeClassPtr, 100663314);
			RegisterEntityView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEntityView>.NativeClassPtr, 100663315);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00009A94 File Offset: 0x00007C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106480, XrefRangeEnd = 1106485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegisterEntityView.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00009ADC File Offset: 0x00007CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106485, XrefRangeEnd = 1106491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterEntityView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00009B10 File Offset: 0x00007D10
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterEntityView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterEntityView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterEntityView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002187 File Offset: 0x00000387
		public RegisterEntityView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00009B4C File Offset: 0x00007D4C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002190 File Offset: 0x00000390
		public unsafe int viewLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterEntityView.NativeFieldInfoPtr_viewLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegisterEntityView.NativeFieldInfoPtr_viewLayer)) = value;
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_viewLayer;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
