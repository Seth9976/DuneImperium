using System;
using boardgames.kabbage;
using Canis.attributes;
using Canis.messages.effect;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus.kabbage;

namespace boardgames.effects
{
	// Token: 0x0200013A RID: 314
	public class PlayFXCommand : Command
	{
		// Token: 0x06001048 RID: 4168 RVA: 0x00042F34 File Offset: 0x00041134
		// Note: this type is marked as 'beforefieldinit'.
		static PlayFXCommand()
		{
			Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.effects", "PlayFXCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr);
			PlayFXCommand.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, "message");
			PlayFXCommand.NativeFieldInfoPtr_sequenceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, "sequenceName");
			PlayFXCommand.NativeFieldInfoPtr_sourceOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, "sourceOverrides");
			PlayFXCommand.NativeMethodInfoPtr_get_FXName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, 100665680);
			PlayFXCommand.NativeMethodInfoPtr_get_Location_Public_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, 100665681);
			PlayFXCommand.NativeMethodInfoPtr_get_Attributes_Public_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, 100665682);
			PlayFXCommand.NativeMethodInfoPtr__ctor_Public_Void_PlayFX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, 100665683);
			PlayFXCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, 100665684);
			PlayFXCommand.NativeMethodInfoPtr_HandleAttributes_Public_Virtual_Final_New_Void_String_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, 100665685);
			PlayFXCommand.NativeMethodInfoPtr_configureMoveContext_Protected_Virtual_New_Void_EntityComponent_FlavoredVFXMoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, 100665686);
			PlayFXCommand.NativeMethodInfoPtr_introduceFXEntity_Protected_Virtual_New_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, 100665687);
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00043040 File Offset: 0x00041240
		public unsafe string FXName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand.NativeMethodInfoPtr_get_FXName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00043078 File Offset: 0x00041278
		public unsafe EntityID Location
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 374429, RefRangeEnd = 374430, XrefRangeStart = 374429, XrefRangeEnd = 374430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand.NativeMethodInfoPtr_get_Location_Public_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x000430B8 File Offset: 0x000412B8
		public unsafe ReadOnlyAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand.NativeMethodInfoPtr_get_Attributes_Public_get_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x000430F8 File Offset: 0x000412F8
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayFXCommand(PlayFX message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand.NativeMethodInfoPtr__ctor_Public_Void_PlayFX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00043144 File Offset: 0x00041344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999186, XrefRangeEnd = 999191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayFXCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00043190 File Offset: 0x00041390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999191, XrefRangeEnd = 999203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleAttributes(string sequenceName, IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand.NativeMethodInfoPtr_HandleAttributes_Public_Virtual_Final_New_Void_String_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x000431E4 File Offset: 0x000413E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999203, XrefRangeEnd = 999214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void configureMoveContext(EntityComponent entityComponent, FlavoredVFXMoveContext moveContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayFXCommand.NativeMethodInfoPtr_configureMoveContext_Protected_Virtual_New_Void_EntityComponent_FlavoredVFXMoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00043244 File Offset: 0x00041444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999214, XrefRangeEnd = 999228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void introduceFXEntity(EntityComponent entityComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayFXCommand.NativeMethodInfoPtr_introduceFXEntity_Protected_Virtual_New_Void_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00009920 File Offset: 0x00007B20
		public PlayFXCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x00043294 File Offset: 0x00041494
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x00009929 File Offset: 0x00007B29
		public unsafe PlayFX message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayFX>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x000432C4 File Offset: 0x000414C4
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x00009948 File Offset: 0x00007B48
		public unsafe string sequenceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand.NativeFieldInfoPtr_sequenceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand.NativeFieldInfoPtr_sequenceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x000432EC File Offset: 0x000414EC
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x00009967 File Offset: 0x00007B67
		public unsafe IAttribute<Dictionary<EntityID, EntityID>> sourceOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand.NativeFieldInfoPtr_sourceOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Dictionary<EntityID, EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand.NativeFieldInfoPtr_sourceOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeFieldInfoPtr_sequenceName;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeFieldInfoPtr_sourceOverrides;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_get_FXName_Public_get_String_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_EntityID_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_ReadOnlyAttributes_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayFX_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_HandleAttributes_Public_Virtual_Final_New_Void_String_IHasAttributes_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_configureMoveContext_Protected_Virtual_New_Void_EntityComponent_FlavoredVFXMoveContext_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_introduceFXEntity_Protected_Virtual_New_Void_EntityComponent_0;

		// Token: 0x02000270 RID: 624
		[ObfuscatedName("boardgames.effects.PlayFXCommand+<execute>d__10")]
		public sealed class _execute_d__10 : Object
		{
			// Token: 0x06001CB9 RID: 7353 RVA: 0x00069B74 File Offset: 0x00067D74
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__10()
			{
				Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayFXCommand>.NativeClassPtr, "<execute>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr);
				PlayFXCommand._execute_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, "<>1__state");
				PlayFXCommand._execute_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, "<>2__current");
				PlayFXCommand._execute_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, "<>4__this");
				PlayFXCommand._execute_d__10.NativeFieldInfoPtr__moveContext_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, "<moveContext>5__2");
				PlayFXCommand._execute_d__10.NativeFieldInfoPtr__destFXLocator_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, "<destFXLocator>5__3");
				PlayFXCommand._execute_d__10.NativeFieldInfoPtr__fxData_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, "<fxData>5__4");
				PlayFXCommand._execute_d__10.NativeFieldInfoPtr__vfx_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, "<vfx>5__5");
				PlayFXCommand._execute_d__10.NativeFieldInfoPtr__block_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, "<block>5__6");
				PlayFXCommand._execute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, 100665688);
				PlayFXCommand._execute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, 100665689);
				PlayFXCommand._execute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, 100665690);
				PlayFXCommand._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, 100665691);
				PlayFXCommand._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, 100665692);
				PlayFXCommand._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr, 100665693);
			}

			// Token: 0x06001CBA RID: 7354 RVA: 0x00069CB8 File Offset: 0x00067EB8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayFXCommand._execute_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand._execute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CBB RID: 7355 RVA: 0x00069D00 File Offset: 0x00067F00
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand._execute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CBC RID: 7356 RVA: 0x00069D34 File Offset: 0x00067F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999056, XrefRangeEnd = 999181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand._execute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700088C RID: 2188
			// (get) Token: 0x06001CBD RID: 7357 RVA: 0x00069D70 File Offset: 0x00067F70
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand._execute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CBE RID: 7358 RVA: 0x00069DB0 File Offset: 0x00067FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999181, XrefRangeEnd = 999186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00069DE4 File Offset: 0x00067FE4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayFXCommand._execute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CC0 RID: 7360 RVA: 0x0000F741 File Offset: 0x0000D941
			public _execute_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00069E24 File Offset: 0x00068024
			// (set) Token: 0x06001CC2 RID: 7362 RVA: 0x0000F74A File Offset: 0x0000D94A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00069E4C File Offset: 0x0006804C
			// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x0000F765 File Offset: 0x0000D965
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00069E7C File Offset: 0x0006807C
			// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x0000F784 File Offset: 0x0000D984
			public unsafe PlayFXCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayFXCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x00069EAC File Offset: 0x000680AC
			// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x0000F7A3 File Offset: 0x0000D9A3
			public unsafe FlavoredVFXMoveContext _moveContext_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr__moveContext_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredVFXMoveContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr__moveContext_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00069EDC File Offset: 0x000680DC
			// (set) Token: 0x06001CCA RID: 7370 RVA: 0x0000F7C2 File Offset: 0x0000D9C2
			public unsafe IEntityFXLocator _destFXLocator_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr__destFXLocator_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEntityFXLocator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr__destFXLocator_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00069F0C File Offset: 0x0006810C
			// (set) Token: 0x06001CCC RID: 7372 RVA: 0x0000F7E1 File Offset: 0x0000D9E1
			public unsafe EntityComponent _fxData_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr__fxData_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr__fxData_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00069F3C File Offset: 0x0006813C
			// (set) Token: 0x06001CCE RID: 7374 RVA: 0x0000F800 File Offset: 0x0000DA00
			public unsafe RunVFXKabbage _vfx_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr__vfx_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunVFXKabbage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr__vfx_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x06001CCF RID: 7375 RVA: 0x00069F6C File Offset: 0x0006816C
			// (set) Token: 0x06001CD0 RID: 7376 RVA: 0x0000F81F File Offset: 0x0000DA1F
			public unsafe IEnumerator _block_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr__block_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayFXCommand._execute_d__10.NativeFieldInfoPtr__block_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400117A RID: 4474
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400117B RID: 4475
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400117C RID: 4476
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400117D RID: 4477
			private static readonly IntPtr NativeFieldInfoPtr__moveContext_5__2;

			// Token: 0x0400117E RID: 4478
			private static readonly IntPtr NativeFieldInfoPtr__destFXLocator_5__3;

			// Token: 0x0400117F RID: 4479
			private static readonly IntPtr NativeFieldInfoPtr__fxData_5__4;

			// Token: 0x04001180 RID: 4480
			private static readonly IntPtr NativeFieldInfoPtr__vfx_5__5;

			// Token: 0x04001181 RID: 4481
			private static readonly IntPtr NativeFieldInfoPtr__block_5__6;

			// Token: 0x04001182 RID: 4482
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001183 RID: 4483
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001184 RID: 4484
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001185 RID: 4485
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001186 RID: 4486
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001187 RID: 4487
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
