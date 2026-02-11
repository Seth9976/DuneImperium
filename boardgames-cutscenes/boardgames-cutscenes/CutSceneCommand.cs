using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.SceneManagement;

namespace lotus
{
	// Token: 0x02000007 RID: 7
	public class CutSceneCommand : Command
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003648 File Offset: 0x00001848
		// Note: this type is marked as 'beforefieldinit'.
		static CutSceneCommand()
		{
			Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutSceneCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr);
			CutSceneCommand.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, "action");
			CutSceneCommand.NativeFieldInfoPtr__cc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, "<cc>k__BackingField");
			CutSceneCommand.NativeFieldInfoPtr_skipToEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, "skipToEnd");
			CutSceneCommand.NativeMethodInfoPtr_get_cc_Public_get_CutsceneContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, 100663322);
			CutSceneCommand.NativeMethodInfoPtr_set_cc_Private_set_Void_CutsceneContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, 100663323);
			CutSceneCommand.NativeMethodInfoPtr__ctor_Public_Void_CutSceneAction_CutsceneContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, 100663324);
			CutSceneCommand.NativeMethodInfoPtr_sceneUnloaded_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, 100663325);
			CutSceneCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, 100663326);
			CutSceneCommand.NativeMethodInfoPtr_executeInternal_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, 100663327);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000372C File Offset: 0x0000192C
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000376C File Offset: 0x0000196C
		public unsafe CutsceneContext cc
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand.NativeMethodInfoPtr_get_cc_Public_get_CutsceneContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CutsceneContext>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand.NativeMethodInfoPtr_set_cc_Private_set_Void_CutsceneContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000037B0 File Offset: 0x000019B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258115, XrefRangeEnd = 1258128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutSceneCommand(CutSceneAction a, CutsceneContext cc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand.NativeMethodInfoPtr__ctor_Public_Void_CutSceneAction_CutsceneContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003810 File Offset: 0x00001A10
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 468865, RefRangeEnd = 468871, XrefRangeStart = 468865, XrefRangeEnd = 468871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sceneUnloaded(Scene scene)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scene;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand.NativeMethodInfoPtr_sceneUnloaded_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003850 File Offset: 0x00001A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258128, XrefRangeEnd = 1258133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000389C File Offset: 0x00001A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258138, RefRangeEnd = 1258139, XrefRangeStart = 1258133, XrefRangeEnd = 1258138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator executeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand.NativeMethodInfoPtr_executeInternal_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002146 File Offset: 0x00000346
		public CutSceneCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000038DC File Offset: 0x00001ADC
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000214F File Offset: 0x0000034F
		public unsafe CutSceneAction action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand.NativeFieldInfoPtr_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutSceneAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000390C File Offset: 0x00001B0C
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000216E File Offset: 0x0000036E
		public unsafe CutsceneContext _cc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand.NativeFieldInfoPtr__cc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutsceneContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand.NativeFieldInfoPtr__cc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000393C File Offset: 0x00001B3C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000218D File Offset: 0x0000038D
		public unsafe bool skipToEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand.NativeFieldInfoPtr_skipToEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand.NativeFieldInfoPtr_skipToEnd)) = value;
			}
		}

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr__cc_k__BackingField;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_skipToEnd;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_cc_Public_get_CutsceneContext_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_set_cc_Private_set_Void_CutsceneContext_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CutSceneAction_CutsceneContext_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_sceneUnloaded_Private_Void_Scene_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_executeInternal_Private_IEnumerator_0;

		// Token: 0x02000021 RID: 33
		[ObfuscatedName("lotus.CutSceneCommand+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x0600011D RID: 285 RVA: 0x0000679C File Offset: 0x0000499C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr);
				CutSceneCommand._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr, "<>1__state");
				CutSceneCommand._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr, "<>2__current");
				CutSceneCommand._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr, "<>4__this");
				CutSceneCommand._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr, 100663328);
				CutSceneCommand._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr, 100663329);
				CutSceneCommand._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr, 100663330);
				CutSceneCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr, 100663331);
				CutSceneCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr, 100663332);
				CutSceneCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr, 100663333);
			}

			// Token: 0x0600011E RID: 286 RVA: 0x0000687C File Offset: 0x00004A7C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneCommand._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600011F RID: 287 RVA: 0x000068C4 File Offset: 0x00004AC4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000120 RID: 288 RVA: 0x000068F8 File Offset: 0x00004AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258102, XrefRangeEnd = 1258104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000121 RID: 289 RVA: 0x00006934 File Offset: 0x00004B34
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00006974 File Offset: 0x00004B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258104, XrefRangeEnd = 1258109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x06000123 RID: 291 RVA: 0x000069A8 File Offset: 0x00004BA8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000124 RID: 292 RVA: 0x00002790 File Offset: 0x00000990
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000125 RID: 293 RVA: 0x000069E8 File Offset: 0x00004BE8
			// (set) Token: 0x06000126 RID: 294 RVA: 0x00002799 File Offset: 0x00000999
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000127 RID: 295 RVA: 0x00006A10 File Offset: 0x00004C10
			// (set) Token: 0x06000128 RID: 296 RVA: 0x000027B4 File Offset: 0x000009B4
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000129 RID: 297 RVA: 0x00006A40 File Offset: 0x00004C40
			// (set) Token: 0x0600012A RID: 298 RVA: 0x000027D3 File Offset: 0x000009D3
			public unsafe CutSceneCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutSceneCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000A9 RID: 169
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000AC RID: 172
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000AD RID: 173
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000AE RID: 174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000AF RID: 175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000B0 RID: 176
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000022 RID: 34
		[ObfuscatedName("lotus.CutSceneCommand+<executeInternal>d__9")]
		public sealed class _executeInternal_d__9 : Object
		{
			// Token: 0x0600012B RID: 299 RVA: 0x00006A70 File Offset: 0x00004C70
			// Note: this type is marked as 'beforefieldinit'.
			static _executeInternal_d__9()
			{
				Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CutSceneCommand>.NativeClassPtr, "<executeInternal>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr);
				CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr, "<>1__state");
				CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr, "<>2__current");
				CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr, "<>4__this");
				CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr__c_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr, "<c>5__2");
				CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr, 100663334);
				CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr, 100663335);
				CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr, 100663336);
				CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr, 100663337);
				CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr, 100663338);
				CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr, 100663339);
			}

			// Token: 0x0600012C RID: 300 RVA: 0x00006B64 File Offset: 0x00004D64
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeInternal_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneCommand._executeInternal_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600012D RID: 301 RVA: 0x00006BAC File Offset: 0x00004DAC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600012E RID: 302 RVA: 0x00006BE0 File Offset: 0x00004DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258109, XrefRangeEnd = 1258110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x0600012F RID: 303 RVA: 0x00006C1C File Offset: 0x00004E1C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000130 RID: 304 RVA: 0x00006C5C File Offset: 0x00004E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258110, XrefRangeEnd = 1258115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000131 RID: 305 RVA: 0x00006C90 File Offset: 0x00004E90
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCommand._executeInternal_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000132 RID: 306 RVA: 0x000027F2 File Offset: 0x000009F2
			public _executeInternal_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00006CD0 File Offset: 0x00004ED0
			// (set) Token: 0x06000134 RID: 308 RVA: 0x000027FB File Offset: 0x000009FB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000135 RID: 309 RVA: 0x00006CF8 File Offset: 0x00004EF8
			// (set) Token: 0x06000136 RID: 310 RVA: 0x00002816 File Offset: 0x00000A16
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000137 RID: 311 RVA: 0x00006D28 File Offset: 0x00004F28
			// (set) Token: 0x06000138 RID: 312 RVA: 0x00002835 File Offset: 0x00000A35
			public unsafe CutSceneCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutSceneCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00006D58 File Offset: 0x00004F58
			// (set) Token: 0x0600013A RID: 314 RVA: 0x00002854 File Offset: 0x00000A54
			public unsafe Command _c_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr__c_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCommand._executeInternal_d__9.NativeFieldInfoPtr__c_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000B1 RID: 177
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000B2 RID: 178
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000B3 RID: 179
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000B4 RID: 180
			private static readonly IntPtr NativeFieldInfoPtr__c_5__2;

			// Token: 0x040000B5 RID: 181
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000B6 RID: 182
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000B7 RID: 183
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000B8 RID: 184
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000B9 RID: 185
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000BA RID: 186
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
