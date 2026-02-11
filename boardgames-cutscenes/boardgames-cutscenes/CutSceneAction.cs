using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000004 RID: 4
	public class CutSceneAction : MonoBehaviour
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00003038 File Offset: 0x00001238
		// Note: this type is marked as 'beforefieldinit'.
		static CutSceneAction()
		{
			Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutSceneAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr);
			CutSceneAction.NativeFieldInfoPtr_initialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr, "initialDelay");
			CutSceneAction.NativeFieldInfoPtr_postDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr, "postDelay");
			CutSceneAction.NativeFieldInfoPtr_wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr, "wait");
			CutSceneAction.NativeMethodInfoPtr_GetCommand_Public_Virtual_New_CutSceneCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr, 100663304);
			CutSceneAction.NativeMethodInfoPtr_GetCommand_Public_Virtual_New_CutSceneCommand_CutsceneContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr, 100663305);
			CutSceneAction.NativeMethodInfoPtr_Play_Public_Virtual_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr, 100663306);
			CutSceneAction.NativeMethodInfoPtr_Play_Public_Virtual_New_Command_CutsceneContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr, 100663307);
			CutSceneAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003108 File Offset: 0x00001308
		[CallerCount(0)]
		public unsafe virtual CutSceneCommand GetCommand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneAction.NativeMethodInfoPtr_GetCommand_Public_Virtual_New_CutSceneCommand_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CutSceneCommand>(intPtr3) : null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003154 File Offset: 0x00001354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258046, XrefRangeEnd = 1258062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual CutSceneCommand GetCommand(CutsceneContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneAction.NativeMethodInfoPtr_GetCommand_Public_Virtual_New_CutSceneCommand_CutsceneContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CutSceneCommand>(intPtr3) : null;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000031B0 File Offset: 0x000013B0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneAction.NativeMethodInfoPtr_Play_Public_Virtual_New_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000031FC File Offset: 0x000013FC
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 373745, RefRangeEnd = 373800, XrefRangeStart = 373745, XrefRangeEnd = 373800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command Play(CutsceneContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneAction.NativeMethodInfoPtr_Play_Public_Virtual_New_Command_CutsceneContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003258 File Offset: 0x00001458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutSceneAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020A0 File Offset: 0x000002A0
		public CutSceneAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00003294 File Offset: 0x00001494
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020A9 File Offset: 0x000002A9
		public unsafe float initialDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneAction.NativeFieldInfoPtr_initialDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneAction.NativeFieldInfoPtr_initialDelay)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000032BC File Offset: 0x000014BC
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020C4 File Offset: 0x000002C4
		public unsafe float postDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneAction.NativeFieldInfoPtr_postDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneAction.NativeFieldInfoPtr_postDelay)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000032E4 File Offset: 0x000014E4
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020DF File Offset: 0x000002DF
		public unsafe bool wait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneAction.NativeFieldInfoPtr_wait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneAction.NativeFieldInfoPtr_wait)) = value;
			}
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_initialDelay;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_postDelay;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_wait;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_GetCommand_Public_Virtual_New_CutSceneCommand_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_GetCommand_Public_Virtual_New_CutSceneCommand_CutsceneContext_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Command_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Command_CutsceneContext_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
