using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.gameLogs
{
	// Token: 0x020000A2 RID: 162
	[Serializable]
	public class GameLogList : Object
	{
		// Token: 0x060007DD RID: 2013 RVA: 0x00039310 File Offset: 0x00037510
		// Note: this type is marked as 'beforefieldinit'.
		static GameLogList()
		{
			Il2CppClassPointerStore<GameLogList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "GameLogList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogList>.NativeClassPtr);
			GameLogList.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogList>.NativeClassPtr, "Items");
			GameLogList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogList>.NativeClassPtr, 100664892);
			GameLogList.NativeMethodInfoPtr_AddItem_Public_GameLogList_LocalizableTextVariables_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogList>.NativeClassPtr, 100664893);
			GameLogList.NativeMethodInfoPtr_AddItem_Public_GameLogList_GameLogListItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogList>.NativeClassPtr, 100664894);
			GameLogList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogList>.NativeClassPtr, 100664895);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000393A4 File Offset: 0x000375A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 558660, RefRangeEnd = 558667, XrefRangeStart = 558652, XrefRangeEnd = 558660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000393E0 File Offset: 0x000375E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 558674, RefRangeEnd = 558675, XrefRangeStart = 558667, XrefRangeEnd = 558674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogList AddItem(LocalizableTextVariables text, int order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogList.NativeMethodInfoPtr_AddItem_Public_GameLogList_LocalizableTextVariables_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogList>(intPtr3) : null;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00039440 File Offset: 0x00037640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 558690, RefRangeEnd = 558691, XrefRangeStart = 558675, XrefRangeEnd = 558690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogList AddItem(GameLogListItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogList.NativeMethodInfoPtr_AddItem_Public_GameLogList_GameLogListItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogList>(intPtr3) : null;
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00039490 File Offset: 0x00037690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558691, XrefRangeEnd = 558759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLogList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00005131 File Offset: 0x00003331
		public GameLogList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x000394D4 File Offset: 0x000376D4
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x0000513A File Offset: 0x0000333A
		public unsafe List<GameLogListItem> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogList.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameLogListItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogList.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_GameLogList_LocalizableTextVariables_Int32_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_GameLogList_GameLogListItem_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
