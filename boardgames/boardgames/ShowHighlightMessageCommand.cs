using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

// Token: 0x02000011 RID: 17
public class ShowHighlightMessageCommand : Command
{
	// Token: 0x0600009E RID: 158 RVA: 0x00012A98 File Offset: 0x00010C98
	// Note: this type is marked as 'beforefieldinit'.
	static ShowHighlightMessageCommand()
	{
		Il2CppClassPointerStore<ShowHighlightMessageCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "ShowHighlightMessageCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowHighlightMessageCommand>.NativeClassPtr);
		ShowHighlightMessageCommand.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowHighlightMessageCommand>.NativeClassPtr, "message");
		ShowHighlightMessageCommand.NativeMethodInfoPtr__ctor_Public_Void_ShowHighlightMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowHighlightMessageCommand>.NativeClassPtr, 100663419);
		ShowHighlightMessageCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowHighlightMessageCommand>.NativeClassPtr, 100663420);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00012B04 File Offset: 0x00010D04
	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowHighlightMessageCommand(ShowHighlightMessage message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowHighlightMessageCommand>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowHighlightMessageCommand.NativeMethodInfoPtr__ctor_Public_Void_ShowHighlightMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00012B50 File Offset: 0x00010D50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982785, XrefRangeEnd = 982790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowHighlightMessageCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x000023C2 File Offset: 0x000005C2
	public ShowHighlightMessageCommand(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060000A2 RID: 162 RVA: 0x00012B9C File Offset: 0x00010D9C
	// (set) Token: 0x060000A3 RID: 163 RVA: 0x000023CB File Offset: 0x000005CB
	public unsafe ShowHighlightMessage message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessageCommand.NativeFieldInfoPtr_message);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowHighlightMessage>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessageCommand.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000071 RID: 113
	private static readonly IntPtr NativeFieldInfoPtr_message;

	// Token: 0x04000072 RID: 114
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShowHighlightMessage_0;

	// Token: 0x04000073 RID: 115
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x02000194 RID: 404
	[ObfuscatedName("ShowHighlightMessageCommand+<execute>d__2")]
	public sealed class _execute_d__2 : Object
	{
		// Token: 0x060013AA RID: 5034 RVA: 0x0004DCE8 File Offset: 0x0004BEE8
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__2()
		{
			Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowHighlightMessageCommand>.NativeClassPtr, "<execute>d__2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr);
			ShowHighlightMessageCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr, "<>1__state");
			ShowHighlightMessageCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr, "<>2__current");
			ShowHighlightMessageCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr, "<>4__this");
			ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr, 100663421);
			ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr, 100663422);
			ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr, 100663423);
			ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr, 100663424);
			ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr, 100663425);
			ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr, 100663426);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0004DDC8 File Offset: 0x0004BFC8
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__2(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowHighlightMessageCommand._execute_d__2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0004DE10 File Offset: 0x0004C010
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0004DE44 File Offset: 0x0004C044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982776, XrefRangeEnd = 982780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x0004DE80 File Offset: 0x0004C080
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0004DEC0 File Offset: 0x0004C0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982780, XrefRangeEnd = 982785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0004DEF4 File Offset: 0x0004C0F4
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowHighlightMessageCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0000B2BC File Offset: 0x000094BC
		public _execute_d__2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0004DF34 File Offset: 0x0004C134
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x0000B2C5 File Offset: 0x000094C5
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessageCommand._execute_d__2.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessageCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0004DF5C File Offset: 0x0004C15C
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x0000B2E0 File Offset: 0x000094E0
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessageCommand._execute_d__2.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessageCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0004DF8C File Offset: 0x0004C18C
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x0000B2FF File Offset: 0x000094FF
		public unsafe ShowHighlightMessageCommand __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessageCommand._execute_d__2.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowHighlightMessageCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessageCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
