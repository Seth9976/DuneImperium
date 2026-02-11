using System;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000E7 RID: 231
	public class WormSourceHeaderPromptBehaviour : PromptBehaviour<IPromptWithData>
	{
		// Token: 0x06000A4B RID: 2635 RVA: 0x00037684 File Offset: 0x00035884
		// Note: this type is marked as 'beforefieldinit'.
		static WormSourceHeaderPromptBehaviour()
		{
			Il2CppClassPointerStore<WormSourceHeaderPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormSourceHeaderPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSourceHeaderPromptBehaviour>.NativeClassPtr);
			WormSourceHeaderPromptBehaviour.NativeFieldInfoPtr_sourceView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSourceHeaderPromptBehaviour>.NativeClassPtr, "sourceView");
			WormSourceHeaderPromptBehaviour.NativeFieldInfoPtr_temporaryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSourceHeaderPromptBehaviour>.NativeClassPtr, "temporaryEntity");
			WormSourceHeaderPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSourceHeaderPromptBehaviour>.NativeClassPtr, 100664713);
			WormSourceHeaderPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSourceHeaderPromptBehaviour>.NativeClassPtr, 100664714);
			WormSourceHeaderPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSourceHeaderPromptBehaviour>.NativeClassPtr, 100664715);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00037718 File Offset: 0x00035918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701420, XrefRangeEnd = 701454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSourceHeaderPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00037754 File Offset: 0x00035954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701454, XrefRangeEnd = 701459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSourceHeaderPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00037788 File Offset: 0x00035988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701459, XrefRangeEnd = 701462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSourceHeaderPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSourceHeaderPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSourceHeaderPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0000762A File Offset: 0x0000582A
		public WormSourceHeaderPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x000377C4 File Offset: 0x000359C4
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00007633 File Offset: 0x00005833
		public unsafe EntityView sourceView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSourceHeaderPromptBehaviour.NativeFieldInfoPtr_sourceView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSourceHeaderPromptBehaviour.NativeFieldInfoPtr_sourceView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000377F4 File Offset: 0x000359F4
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00007652 File Offset: 0x00005852
		public unsafe EntityComponent temporaryEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSourceHeaderPromptBehaviour.NativeFieldInfoPtr_temporaryEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSourceHeaderPromptBehaviour.NativeFieldInfoPtr_temporaryEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeFieldInfoPtr_sourceView;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeFieldInfoPtr_temporaryEntity;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
