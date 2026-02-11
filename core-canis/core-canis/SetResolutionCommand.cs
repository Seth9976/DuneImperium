using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000061 RID: 97
public class SetResolutionCommand : Command
{
	// Token: 0x0600070A RID: 1802 RVA: 0x00030190 File Offset: 0x0002E390
	// Note: this type is marked as 'beforefieldinit'.
	static SetResolutionCommand()
	{
		Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "SetResolutionCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr);
		SetResolutionCommand.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr, "width");
		SetResolutionCommand.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr, "height");
		SetResolutionCommand.NativeFieldInfoPtr_fullScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr, "fullScreen");
		SetResolutionCommand.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr, 100664368);
		SetResolutionCommand.NativeMethodInfoPtr_get_WillUpdate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr, 100664369);
		SetResolutionCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr, 100664370);
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00030238 File Offset: 0x0002E438
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 860652, RefRangeEnd = 860654, XrefRangeStart = 860651, XrefRangeEnd = 860652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SetResolutionCommand(int width, int height, bool fullScreen)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref width;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullScreen;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x0600070C RID: 1804 RVA: 0x0003029C File Offset: 0x0002E49C
	public unsafe bool WillUpdate
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860654, XrefRangeEnd = 860657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand.NativeMethodInfoPtr_get_WillUpdate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x000302D8 File Offset: 0x0002E4D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860657, XrefRangeEnd = 860662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetResolutionCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x000043EB File Offset: 0x000025EB
	public SetResolutionCommand(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x0600070F RID: 1807 RVA: 0x00030324 File Offset: 0x0002E524
	// (set) Token: 0x06000710 RID: 1808 RVA: 0x000043F4 File Offset: 0x000025F4
	public unsafe int width
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand.NativeFieldInfoPtr_width);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand.NativeFieldInfoPtr_width)) = value;
		}
	}

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06000711 RID: 1809 RVA: 0x0003034C File Offset: 0x0002E54C
	// (set) Token: 0x06000712 RID: 1810 RVA: 0x0000440F File Offset: 0x0000260F
	public unsafe int height
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand.NativeFieldInfoPtr_height);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand.NativeFieldInfoPtr_height)) = value;
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06000713 RID: 1811 RVA: 0x00030374 File Offset: 0x0002E574
	// (set) Token: 0x06000714 RID: 1812 RVA: 0x0000442A File Offset: 0x0000262A
	public unsafe bool fullScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand.NativeFieldInfoPtr_fullScreen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand.NativeFieldInfoPtr_fullScreen)) = value;
		}
	}

	// Token: 0x0400055B RID: 1371
	private static readonly IntPtr NativeFieldInfoPtr_width;

	// Token: 0x0400055C RID: 1372
	private static readonly IntPtr NativeFieldInfoPtr_height;

	// Token: 0x0400055D RID: 1373
	private static readonly IntPtr NativeFieldInfoPtr_fullScreen;

	// Token: 0x0400055E RID: 1374
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;

	// Token: 0x0400055F RID: 1375
	private static readonly IntPtr NativeMethodInfoPtr_get_WillUpdate_Public_get_Boolean_0;

	// Token: 0x04000560 RID: 1376
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x0200027B RID: 635
	[ObfuscatedName("SetResolutionCommand+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06001EE0 RID: 7904 RVA: 0x0008D150 File Offset: 0x0008B350
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<SetResolutionCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetResolutionCommand.__c>.NativeClassPtr);
			SetResolutionCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetResolutionCommand.__c>.NativeClassPtr, "<>9");
			SetResolutionCommand.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetResolutionCommand.__c>.NativeClassPtr, "<>9__6_0");
			SetResolutionCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand.__c>.NativeClassPtr, 100664372);
			SetResolutionCommand.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_Command_IScreenResizeHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand.__c>.NativeClassPtr, 100664373);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0008D1CC File Offset: 0x0008B3CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetResolutionCommand.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0008D208 File Offset: 0x0008B408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860517, XrefRangeEnd = 860536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command _execute_b__6_0(IScreenResizeHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_Command_IScreenResizeHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x0000D20B File Offset: 0x0000B40B
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x0008D258 File Offset: 0x0008B458
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x0000D214 File Offset: 0x0000B414
		public unsafe static SetResolutionCommand.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SetResolutionCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetResolutionCommand.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetResolutionCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x0008D280 File Offset: 0x0008B480
		// (set) Token: 0x06001EE7 RID: 7911 RVA: 0x0000D226 File Offset: 0x0000B426
		public unsafe static Func<IScreenResizeHandler, Command> __9__6_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SetResolutionCommand.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IScreenResizeHandler, Command>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetResolutionCommand.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__6_0_Internal_Command_IScreenResizeHandler_0;
	}

	// Token: 0x0200027C RID: 636
	[ObfuscatedName("SetResolutionCommand+<execute>d__6")]
	public sealed class _execute_d__6 : Object
	{
		// Token: 0x06001EE8 RID: 7912 RVA: 0x0008D2A8 File Offset: 0x0008B4A8
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__6()
		{
			Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetResolutionCommand>.NativeClassPtr, "<execute>d__6");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr);
			SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, "<>1__state");
			SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, "<>2__current");
			SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, "<>4__this");
			SetResolutionCommand._execute_d__6.NativeFieldInfoPtr__handlers_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, "<handlers>5__2");
			SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, "<>7__wrap2");
			SetResolutionCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, 100664374);
			SetResolutionCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, 100664375);
			SetResolutionCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, 100664376);
			SetResolutionCommand._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, 100664377);
			SetResolutionCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, 100664378);
			SetResolutionCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, 100664379);
			SetResolutionCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr, 100664380);
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x0008D3C4 File Offset: 0x0008B5C4
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__6(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetResolutionCommand._execute_d__6>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x0008D40C File Offset: 0x0008B60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860536, XrefRangeEnd = 860539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0008D440 File Offset: 0x0008B640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860539, XrefRangeEnd = 860640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0008D47C File Offset: 0x0008B67C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 860645, RefRangeEnd = 860646, XrefRangeStart = 860640, XrefRangeEnd = 860645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x0008D4B0 File Offset: 0x0008B6B0
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0008D4F0 File Offset: 0x0008B6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860646, XrefRangeEnd = 860651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0008D524 File Offset: 0x0008B724
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetResolutionCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0000D238 File Offset: 0x0000B438
		public _execute_d__6(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x0008D564 File Offset: 0x0008B764
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x0000D241 File Offset: 0x0000B441
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0008D58C File Offset: 0x0008B78C
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x0000D25C File Offset: 0x0000B45C
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x0008D5BC File Offset: 0x0008B7BC
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x0000D27B File Offset: 0x0000B47B
		public unsafe SetResolutionCommand __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetResolutionCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x0008D5EC File Offset: 0x0008B7EC
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x0000D29A File Offset: 0x0000B49A
		public unsafe List<IScreenResizeHandler> _handlers_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand._execute_d__6.NativeFieldInfoPtr__handlers_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IScreenResizeHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand._execute_d__6.NativeFieldInfoPtr__handlers_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x0008D61C File Offset: 0x0008B81C
		// (set) Token: 0x06001EFA RID: 7930 RVA: 0x0000D2B9 File Offset: 0x0000B4B9
		public unsafe IEnumerator __7__wrap2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___7__wrap2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetResolutionCommand._execute_d__6.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeFieldInfoPtr__handlers_5__2;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
