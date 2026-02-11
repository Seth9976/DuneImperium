using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.menus.ui
{
	// Token: 0x020001B1 RID: 433
	public class StopwatchDisplay : TimerDisplay
	{
		// Token: 0x0600137A RID: 4986 RVA: 0x0005C9BC File Offset: 0x0005ABBC
		// Note: this type is marked as 'beforefieldinit'.
		static StopwatchDisplay()
		{
			Il2CppClassPointerStore<StopwatchDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.ui", "StopwatchDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopwatchDisplay>.NativeClassPtr);
			StopwatchDisplay.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchDisplay>.NativeClassPtr, 100666177);
			StopwatchDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchDisplay>.NativeClassPtr, 100666178);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0005CA14 File Offset: 0x0005AC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519436, XrefRangeEnd = 519452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopwatchDisplay.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0005CA48 File Offset: 0x0005AC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519452, XrefRangeEnd = 519453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StopwatchDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopwatchDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopwatchDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0000B256 File Offset: 0x00009456
		public StopwatchDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003A8 RID: 936
		[ObfuscatedName("boardgames.menus.ui.StopwatchDisplay+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06002BE8 RID: 11240 RVA: 0x000ABD3C File Offset: 0x000A9F3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<StopwatchDisplay.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StopwatchDisplay>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopwatchDisplay.__c__DisplayClass0_0>.NativeClassPtr);
				StopwatchDisplay.__c__DisplayClass0_0.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopwatchDisplay.__c__DisplayClass0_0>.NativeClassPtr, "startTime");
				StopwatchDisplay.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchDisplay.__c__DisplayClass0_0>.NativeClassPtr, 100666179);
				StopwatchDisplay.__c__DisplayClass0_0.NativeMethodInfoPtr__Start_b__0_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopwatchDisplay.__c__DisplayClass0_0>.NativeClassPtr, 100666180);
			}

			// Token: 0x06002BE9 RID: 11241 RVA: 0x000ABDA4 File Offset: 0x000A9FA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopwatchDisplay.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopwatchDisplay.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BEA RID: 11242 RVA: 0x000ABDE0 File Offset: 0x000A9FE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519431, XrefRangeEnd = 519436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StopwatchDisplay.__c__DisplayClass0_0.NativeMethodInfoPtr__Start_b__0_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002BEB RID: 11243 RVA: 0x00016B66 File Offset: 0x00014D66
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C75 RID: 3189
			// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000ABE1C File Offset: 0x000AA01C
			// (set) Token: 0x06002BED RID: 11245 RVA: 0x00016B6F File Offset: 0x00014D6F
			public unsafe DateTime startTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopwatchDisplay.__c__DisplayClass0_0.NativeFieldInfoPtr_startTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StopwatchDisplay.__c__DisplayClass0_0.NativeFieldInfoPtr_startTime)) = value;
				}
			}

			// Token: 0x04001B57 RID: 6999
			private static readonly IntPtr NativeFieldInfoPtr_startTime;

			// Token: 0x04001B58 RID: 7000
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B59 RID: 7001
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_TimeSpan_0;
		}
	}
}
