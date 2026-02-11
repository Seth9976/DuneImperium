using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.tutorialScripts
{
	// Token: 0x0200003B RID: 59
	public class GenericTutorialScript<T> : AdvancedTutorialScript where T : TutorialAction, new()
	{
		// Token: 0x06000390 RID: 912 RVA: 0x00027BAC File Offset: 0x00025DAC
		// Note: this type is marked as 'beforefieldinit'.
		static GenericTutorialScript()
		{
			Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.tutorialScripts", "GenericTutorialScript`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr);
			GenericTutorialScript<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr, 100664097);
			GenericTutorialScript<T>.NativeMethodInfoPtr_BuildDialog_Protected_T_Int32_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr, 100664098);
			GenericTutorialScript<T>.NativeMethodInfoPtr_VisualHighlight_Protected_T_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr, 100664099);
			GenericTutorialScript<T>.NativeMethodInfoPtr_VisualHighlight_Protected_T_Int32_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr, 100664100);
			GenericTutorialScript<T>.NativeMethodInfoPtr_CallToAction_Protected_T_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr, 100664101);
			GenericTutorialScript<T>.NativeMethodInfoPtr_MozCardCTA_Protected_Action_Int32_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr, 100664102);
			GenericTutorialScript<T>.NativeMethodInfoPtr_HideTutorialAction_Protected_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr, 100664103);
			GenericTutorialScript<T>.NativeMethodInfoPtr_HintAction_Protected_T_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr, 100664104);
			GenericTutorialScript<T>.NativeMethodInfoPtr_HintAction_Protected_T_Int32_byref_T_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr, 100664105);
			GenericTutorialScript<T>.NativeMethodInfoPtr_InvokeTutorialEvent_Protected_T_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr, 100664106);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00027CE0 File Offset: 0x00025EE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 550911, RefRangeEnd = 550912, XrefRangeStart = 550910, XrefRangeEnd = 550911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericTutorialScript(Match match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericTutorialScript<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericTutorialScript<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00027D2C File Offset: 0x00025F2C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 550913, RefRangeEnd = 550926, XrefRangeStart = 550912, XrefRangeEnd = 550913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T BuildDialog(int id, string text, bool blocking = true, string dialogType = "ClickToContinue")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blocking;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericTutorialScript<T>.NativeMethodInfoPtr_BuildDialog_Protected_T_Int32_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00027DA8 File Offset: 0x00025FA8
		[CallerCount(144)]
		[CachedScanResults(RefRangeStart = 550929, RefRangeEnd = 551073, XrefRangeStart = 550926, XrefRangeEnd = 550929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T VisualHighlight(int id, string identifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericTutorialScript<T>.NativeMethodInfoPtr_VisualHighlight_Protected_T_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00027E00 File Offset: 0x00026000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 551076, RefRangeEnd = 551079, XrefRangeStart = 551073, XrefRangeEnd = 551076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T VisualHighlight(int id, string identifier, out T hide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref hide;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GenericTutorialScript<T>.NativeMethodInfoPtr_VisualHighlight_Protected_T_Int32_String_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				hide = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00027EA8 File Offset: 0x000260A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 551082, RefRangeEnd = 551087, XrefRangeStart = 551079, XrefRangeEnd = 551082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CallToAction(int id, string identifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericTutorialScript<T>.NativeMethodInfoPtr_CallToAction_Protected_T_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00027F00 File Offset: 0x00026100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 551141, RefRangeEnd = 551142, XrefRangeStart = 551087, XrefRangeEnd = 551141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action MozCardCTA(int id, Action<T> addEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(addEntity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericTutorialScript<T>.NativeMethodInfoPtr_MozCardCTA_Protected_Action_Int32_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00027F60 File Offset: 0x00026160
		[CallerCount(193)]
		[CachedScanResults(RefRangeStart = 551145, RefRangeEnd = 551338, XrefRangeStart = 551142, XrefRangeEnd = 551145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T HideTutorialAction(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericTutorialScript<T>.NativeMethodInfoPtr_HideTutorialAction_Protected_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00027FA8 File Offset: 0x000261A8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 551339, RefRangeEnd = 551367, XrefRangeStart = 551338, XrefRangeEnd = 551339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T HintAction(int id, [Optional] Il2CppStringArray vfxTags)
		{
			if (vfxTags == null)
			{
				vfxTags = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericTutorialScript<T>.NativeMethodInfoPtr_HintAction_Protected_T_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00028010 File Offset: 0x00026210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 551367, XrefRangeEnd = 551368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T HintAction(int id, out T hide, [Optional] Il2CppStringArray vfxTags)
		{
			if (vfxTags == null)
			{
				vfxTags = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref hide;
			}
			ptr2 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GenericTutorialScript<T>.NativeMethodInfoPtr_HintAction_Protected_T_Int32_byref_T_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				hide = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000280C4 File Offset: 0x000262C4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 551369, RefRangeEnd = 551392, XrefRangeStart = 551368, XrefRangeEnd = 551369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T InvokeTutorialEvent(int id, string eventName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericTutorialScript<T>.NativeMethodInfoPtr_InvokeTutorialEvent_Protected_T_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000038CF File Offset: 0x00001ACF
		public T HintAction(int id, params string[] vfxTags)
		{
			return this.HintAction(id, new Il2CppStringArray(vfxTags));
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000038DE File Offset: 0x00001ADE
		public T HintAction(int id, out T hide, params string[] vfxTags)
		{
			return this.HintAction(id, out hide, new Il2CppStringArray(vfxTags));
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000038EE File Offset: 0x00001AEE
		public GenericTutorialScript(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_BuildDialog_Protected_T_Int32_String_Boolean_String_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_VisualHighlight_Protected_T_Int32_String_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_VisualHighlight_Protected_T_Int32_String_byref_T_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_CallToAction_Protected_T_Int32_String_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_MozCardCTA_Protected_Action_Int32_Action_1_T_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_HideTutorialAction_Protected_T_Int32_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_HintAction_Protected_T_Int32_Il2CppStringArray_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_HintAction_Protected_T_Int32_byref_T_Il2CppStringArray_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTutorialEvent_Protected_T_Int32_String_0;
	}
}
