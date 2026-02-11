using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

// Token: 0x0200000E RID: 14
public class GameEffectMessageCommand : SequenceEffect<GameEffectMessage>
{
	// Token: 0x06000090 RID: 144 RVA: 0x00012670 File Offset: 0x00010870
	// Note: this type is marked as 'beforefieldinit'.
	static GameEffectMessageCommand()
	{
		Il2CppClassPointerStore<GameEffectMessageCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "GameEffectMessageCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameEffectMessageCommand>.NativeClassPtr);
		GameEffectMessageCommand.NativeMethodInfoPtr__ctor_Public_Void_GameEffectMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEffectMessageCommand>.NativeClassPtr, 100663401);
		GameEffectMessageCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEffectMessageCommand>.NativeClassPtr, 100663402);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x000126C8 File Offset: 0x000108C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982751, XrefRangeEnd = 982754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEffectMessageCommand(GameEffectMessage effect)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEffectMessageCommand>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEffectMessageCommand.NativeMethodInfoPtr__ctor_Public_Void_GameEffectMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00012714 File Offset: 0x00010914
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982754, XrefRangeEnd = 982758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameEffectMessageCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x000023A7 File Offset: 0x000005A7
	public GameEffectMessageCommand(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400006A RID: 106
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEffectMessage_0;

	// Token: 0x0400006B RID: 107
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x02000192 RID: 402
	[ObfuscatedName("GameEffectMessageCommand+<execute>d__1")]
	public sealed class _execute_d__1 : Object
	{
		// Token: 0x06001392 RID: 5010 RVA: 0x0004D7C8 File Offset: 0x0004B9C8
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__1()
		{
			Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameEffectMessageCommand>.NativeClassPtr, "<execute>d__1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr);
			GameEffectMessageCommand._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr, "<>1__state");
			GameEffectMessageCommand._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr, "<>2__current");
			GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr, 100663403);
			GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr, 100663404);
			GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr, 100663405);
			GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr, 100663406);
			GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr, 100663407);
			GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr, 100663408);
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x0004D894 File Offset: 0x0004BA94
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__1(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEffectMessageCommand._execute_d__1>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0004D8DC File Offset: 0x0004BADC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0004D910 File Offset: 0x0004BB10
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x0004D94C File Offset: 0x0004BB4C
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0004D98C File Offset: 0x0004BB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982746, XrefRangeEnd = 982751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0004D9C0 File Offset: 0x0004BBC0
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEffectMessageCommand._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0000B236 File Offset: 0x00009436
		public _execute_d__1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0004DA00 File Offset: 0x0004BC00
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x0000B23F File Offset: 0x0000943F
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEffectMessageCommand._execute_d__1.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEffectMessageCommand._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0004DA28 File Offset: 0x0004BC28
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x0000B25A File Offset: 0x0000945A
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEffectMessageCommand._execute_d__1.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEffectMessageCommand._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
