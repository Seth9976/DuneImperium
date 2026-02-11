using System;
using dwd.core.match;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;

namespace boardgames.match.views
{
	// Token: 0x0200024E RID: 590
	public class AllPlayerViewsLoader : VoodooView
	{
		// Token: 0x06001AD8 RID: 6872 RVA: 0x000750DC File Offset: 0x000732DC
		// Note: this type is marked as 'beforefieldinit'.
		static AllPlayerViewsLoader()
		{
			Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.views", "AllPlayerViewsLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr);
			AllPlayerViewsLoader.NativeFieldInfoPtr_localPlayerAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr, "localPlayerAnchor");
			AllPlayerViewsLoader.NativeFieldInfoPtr_opponentAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr, "opponentAnchor");
			AllPlayerViewsLoader.NativeFieldInfoPtr_selectionAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr, "selectionAnchor");
			AllPlayerViewsLoader.NativeFieldInfoPtr_prefabByFlavorLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr, "prefabByFlavorLoader");
			AllPlayerViewsLoader.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr, 100667582);
			AllPlayerViewsLoader.NativeMethodInfoPtr_InitFromContext_Public_Virtual_Void_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr, 100667583);
			AllPlayerViewsLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr, 100667584);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00075198 File Offset: 0x00073398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532731, XrefRangeEnd = 532736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllPlayerViewsLoader.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x000751D4 File Offset: 0x000733D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532736, XrefRangeEnd = 532847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitFromContext(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllPlayerViewsLoader.NativeMethodInfoPtr_InitFromContext_Public_Virtual_Void_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00075224 File Offset: 0x00073424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532847, XrefRangeEnd = 532848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllPlayerViewsLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllPlayerViewsLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0000EA7A File Offset: 0x0000CC7A
		public AllPlayerViewsLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x00075260 File Offset: 0x00073460
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x0000EA83 File Offset: 0x0000CC83
		public unsafe Transform localPlayerAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllPlayerViewsLoader.NativeFieldInfoPtr_localPlayerAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllPlayerViewsLoader.NativeFieldInfoPtr_localPlayerAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x00075290 File Offset: 0x00073490
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x0000EAA2 File Offset: 0x0000CCA2
		public unsafe Transform opponentAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllPlayerViewsLoader.NativeFieldInfoPtr_opponentAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllPlayerViewsLoader.NativeFieldInfoPtr_opponentAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x000752C0 File Offset: 0x000734C0
		// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x0000EAC1 File Offset: 0x0000CCC1
		public unsafe Transform selectionAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllPlayerViewsLoader.NativeFieldInfoPtr_selectionAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllPlayerViewsLoader.NativeFieldInfoPtr_selectionAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x000752F0 File Offset: 0x000734F0
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x0000EAE0 File Offset: 0x0000CCE0
		public unsafe PrefabByFlavorLoader prefabByFlavorLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllPlayerViewsLoader.NativeFieldInfoPtr_prefabByFlavorLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllPlayerViewsLoader.NativeFieldInfoPtr_prefabByFlavorLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerAnchor;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeFieldInfoPtr_opponentAnchor;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeFieldInfoPtr_selectionAnchor;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeFieldInfoPtr_prefabByFlavorLoader;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_InitFromContext_Public_Virtual_Void_EntityInitializationContext_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200043F RID: 1087
		[ObfuscatedName("boardgames.match.views.AllPlayerViewsLoader+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06003368 RID: 13160 RVA: 0x000C1E3C File Offset: 0x000C003C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AllPlayerViewsLoader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllPlayerViewsLoader>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllPlayerViewsLoader.__c>.NativeClassPtr);
				AllPlayerViewsLoader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllPlayerViewsLoader.__c>.NativeClassPtr, "<>9");
				AllPlayerViewsLoader.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllPlayerViewsLoader.__c>.NativeClassPtr, "<>9__5_0");
				AllPlayerViewsLoader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllPlayerViewsLoader.__c>.NativeClassPtr, 100667586);
				AllPlayerViewsLoader.__c.NativeMethodInfoPtr__InitFromContext_b__5_0_Internal_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllPlayerViewsLoader.__c>.NativeClassPtr, 100667587);
			}

			// Token: 0x06003369 RID: 13161 RVA: 0x000C1EB8 File Offset: 0x000C00B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllPlayerViewsLoader.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllPlayerViewsLoader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600336A RID: 13162 RVA: 0x000C1EF4 File Offset: 0x000C00F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532729, XrefRangeEnd = 532731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _InitFromContext_b__5_0(EntityComponent p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllPlayerViewsLoader.__c.NativeMethodInfoPtr__InitFromContext_b__5_0_Internal_String_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600336B RID: 13163 RVA: 0x0001A8BC File Offset: 0x00018ABC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F00 RID: 3840
			// (get) Token: 0x0600336C RID: 13164 RVA: 0x000C1F3C File Offset: 0x000C013C
			// (set) Token: 0x0600336D RID: 13165 RVA: 0x0001A8C5 File Offset: 0x00018AC5
			public unsafe static AllPlayerViewsLoader.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AllPlayerViewsLoader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AllPlayerViewsLoader.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AllPlayerViewsLoader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F01 RID: 3841
			// (get) Token: 0x0600336E RID: 13166 RVA: 0x000C1F64 File Offset: 0x000C0164
			// (set) Token: 0x0600336F RID: 13167 RVA: 0x0001A8D7 File Offset: 0x00018AD7
			public unsafe static Func<EntityComponent, string> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AllPlayerViewsLoader.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AllPlayerViewsLoader.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FB5 RID: 8117
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001FB6 RID: 8118
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001FB7 RID: 8119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FB8 RID: 8120
			private static readonly IntPtr NativeMethodInfoPtr__InitFromContext_b__5_0_Internal_String_EntityComponent_0;
		}
	}
}
