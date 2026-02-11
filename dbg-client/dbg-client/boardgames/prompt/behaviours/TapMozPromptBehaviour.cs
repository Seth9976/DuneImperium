using System;
using boardgames.moz;
using boardgames.prompts;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace boardgames.prompt.behaviours
{
	// Token: 0x02000105 RID: 261
	public class TapMozPromptBehaviour : PromptBehaviour<TapMozPrompt>
	{
		// Token: 0x06000B80 RID: 2944 RVA: 0x00041F04 File Offset: 0x00040104
		// Note: this type is marked as 'beforefieldinit'.
		static TapMozPromptBehaviour()
		{
			Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompt.behaviours", "TapMozPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr);
			TapMozPromptBehaviour.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr, "container");
			TapMozPromptBehaviour.NativeFieldInfoPtr_hangersLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr, "hangersLoader");
			TapMozPromptBehaviour.NativeFieldInfoPtr_tempContainerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr, "tempContainerEntity");
			TapMozPromptBehaviour.NativeMethodInfoPtr_get_Container_Public_get_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr, 100664972);
			TapMozPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr, 100664973);
			TapMozPromptBehaviour.NativeMethodInfoPtr_AddView_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr, 100664974);
			TapMozPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr, 100664975);
			TapMozPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr, 100664976);
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00041FD4 File Offset: 0x000401D4
		public unsafe ContainerView Container
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptBehaviour.NativeMethodInfoPtr_get_Container_Public_get_ContainerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr3) : null;
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00042014 File Offset: 0x00040214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508612, XrefRangeEnd = 508627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TapMozPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00042050 File Offset: 0x00040250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 508633, RefRangeEnd = 508635, XrefRangeStart = 508627, XrefRangeEnd = 508633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddView(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptBehaviour.NativeMethodInfoPtr_AddView_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00042094 File Offset: 0x00040294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508635, XrefRangeEnd = 508640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000420C8 File Offset: 0x000402C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508640, XrefRangeEnd = 508643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TapMozPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TapMozPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TapMozPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00007804 File Offset: 0x00005A04
		public TapMozPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00042104 File Offset: 0x00040304
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x0000780D File Offset: 0x00005A0D
		public unsafe ContainerView container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptBehaviour.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptBehaviour.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00042134 File Offset: 0x00040334
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0000782C File Offset: 0x00005A2C
		public unsafe CardHangersLoader hangersLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptBehaviour.NativeFieldInfoPtr_hangersLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardHangersLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptBehaviour.NativeFieldInfoPtr_hangersLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00042164 File Offset: 0x00040364
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x0000784B File Offset: 0x00005A4B
		public unsafe EntityComponent tempContainerEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptBehaviour.NativeFieldInfoPtr_tempContainerEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TapMozPromptBehaviour.NativeFieldInfoPtr_tempContainerEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_hangersLoader;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_tempContainerEntity;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_get_Container_Public_get_ContainerView_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_AddView_Public_Void_EntityComponent_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
