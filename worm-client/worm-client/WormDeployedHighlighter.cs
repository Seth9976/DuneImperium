using System;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x0200000D RID: 13
public class WormDeployedHighlighter : MonoBehaviour
{
	// Token: 0x06000046 RID: 70 RVA: 0x0001985C File Offset: 0x00017A5C
	// Note: this type is marked as 'beforefieldinit'.
	static WormDeployedHighlighter()
	{
		Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormDeployedHighlighter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr);
		WormDeployedHighlighter.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, "highlight");
		WormDeployedHighlighter.NativeFieldInfoPtr_removeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, "removeEffect");
		WormDeployedHighlighter.NativeFieldInfoPtr_addFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, "addFX");
		WormDeployedHighlighter.NativeFieldInfoPtr_hideFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, "hideFX");
		WormDeployedHighlighter.NativeFieldInfoPtr_hideCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, "hideCoroutine");
		WormDeployedHighlighter.NativeMethodInfoPtr_Event_SetHighlight_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, 100663339);
		WormDeployedHighlighter.NativeMethodInfoPtr_Event_ShowAddFX_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, 100663340);
		WormDeployedHighlighter.NativeMethodInfoPtr_Event_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, 100663341);
		WormDeployedHighlighter.NativeMethodInfoPtr_Hide_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, 100663342);
		WormDeployedHighlighter.NativeMethodInfoPtr_Event_SpawnRemoveEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, 100663343);
		WormDeployedHighlighter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, 100663344);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00019968 File Offset: 0x00017B68
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 687116, RefRangeEnd = 687119, XrefRangeStart = 687114, XrefRangeEnd = 687116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_SetHighlight(bool active)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter.NativeMethodInfoPtr_Event_SetHighlight_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x000199A8 File Offset: 0x00017BA8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 687123, RefRangeEnd = 687126, XrefRangeStart = 687119, XrefRangeEnd = 687123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ShowAddFX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter.NativeMethodInfoPtr_Event_ShowAddFX_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000199DC File Offset: 0x00017BDC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 687133, RefRangeEnd = 687136, XrefRangeStart = 687126, XrefRangeEnd = 687133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter.NativeMethodInfoPtr_Event_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00019A10 File Offset: 0x00017C10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687136, XrefRangeEnd = 687141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter.NativeMethodInfoPtr_Hide_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00019A50 File Offset: 0x00017C50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687141, XrefRangeEnd = 687153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_SpawnRemoveEffect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter.NativeMethodInfoPtr_Event_SpawnRemoveEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00019A84 File Offset: 0x00017C84
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormDeployedHighlighter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002231 File Offset: 0x00000431
	public WormDeployedHighlighter(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600004E RID: 78 RVA: 0x00019AC0 File Offset: 0x00017CC0
	// (set) Token: 0x0600004F RID: 79 RVA: 0x0000223A File Offset: 0x0000043A
	public unsafe GameObject highlight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter.NativeFieldInfoPtr_highlight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter.NativeFieldInfoPtr_highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000050 RID: 80 RVA: 0x00019AF0 File Offset: 0x00017CF0
	// (set) Token: 0x06000051 RID: 81 RVA: 0x00002259 File Offset: 0x00000459
	public unsafe GameObject removeEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter.NativeFieldInfoPtr_removeEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter.NativeFieldInfoPtr_removeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000052 RID: 82 RVA: 0x00019B20 File Offset: 0x00017D20
	// (set) Token: 0x06000053 RID: 83 RVA: 0x00002278 File Offset: 0x00000478
	public unsafe TriggeredBlockingAnimation addFX
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter.NativeFieldInfoPtr_addFX);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter.NativeFieldInfoPtr_addFX), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000054 RID: 84 RVA: 0x00019B50 File Offset: 0x00017D50
	// (set) Token: 0x06000055 RID: 85 RVA: 0x00002297 File Offset: 0x00000497
	public unsafe TriggeredBlockingAnimation hideFX
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter.NativeFieldInfoPtr_hideFX);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter.NativeFieldInfoPtr_hideFX), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000056 RID: 86 RVA: 0x00019B80 File Offset: 0x00017D80
	// (set) Token: 0x06000057 RID: 87 RVA: 0x000022B6 File Offset: 0x000004B6
	public unsafe Coroutine hideCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter.NativeFieldInfoPtr_hideCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter.NativeFieldInfoPtr_hideCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeFieldInfoPtr_highlight;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeFieldInfoPtr_removeEffect;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeFieldInfoPtr_addFX;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeFieldInfoPtr_hideFX;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeFieldInfoPtr_hideCoroutine;

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeMethodInfoPtr_Event_SetHighlight_Public_Void_Boolean_0;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr_Event_ShowAddFX_Public_Void_0;

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeMethodInfoPtr_Event_Hide_Public_Void_0;

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeMethodInfoPtr_Hide_Private_IEnumerator_0;

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeMethodInfoPtr_Event_SpawnRemoveEffect_Public_Void_0;

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002AD RID: 685
	[ObfuscatedName("WormDeployedHighlighter+<Hide>d__8")]
	public sealed class _Hide_d__8 : global::Il2CppSystem.Object
	{
		// Token: 0x06001BEB RID: 7147 RVA: 0x0006DF98 File Offset: 0x0006C198
		// Note: this type is marked as 'beforefieldinit'.
		static _Hide_d__8()
		{
			Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormDeployedHighlighter>.NativeClassPtr, "<Hide>d__8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr);
			WormDeployedHighlighter._Hide_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr, "<>1__state");
			WormDeployedHighlighter._Hide_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr, "<>2__current");
			WormDeployedHighlighter._Hide_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr, "<>4__this");
			WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr, 100663345);
			WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr, 100663346);
			WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr, 100663347);
			WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr, 100663348);
			WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr, 100663349);
			WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr, 100663350);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0006E078 File Offset: 0x0006C278
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Hide_d__8(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDeployedHighlighter._Hide_d__8>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0006E0C0 File Offset: 0x0006C2C0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0006E0F4 File Offset: 0x0006C2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687107, XrefRangeEnd = 687109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x0006E130 File Offset: 0x0006C330
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0006E170 File Offset: 0x0006C370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687109, XrefRangeEnd = 687114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x0006E1A4 File Offset: 0x0006C3A4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDeployedHighlighter._Hide_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00010117 File Offset: 0x0000E317
		public _Hide_d__8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x0006E1E4 File Offset: 0x0006C3E4
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x00010120 File Offset: 0x0000E320
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter._Hide_d__8.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter._Hide_d__8.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0006E20C File Offset: 0x0006C40C
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x0001013B File Offset: 0x0000E33B
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter._Hide_d__8.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter._Hide_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x0006E23C File Offset: 0x0006C43C
		// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x0001015A File Offset: 0x0000E35A
		public unsafe WormDeployedHighlighter __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter._Hide_d__8.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDeployedHighlighter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDeployedHighlighter._Hide_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
