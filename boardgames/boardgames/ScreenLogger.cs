using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000026 RID: 38
public class ScreenLogger : MonoBehaviour
{
	// Token: 0x06000134 RID: 308 RVA: 0x000145D4 File Offset: 0x000127D4
	// Note: this type is marked as 'beforefieldinit'.
	static ScreenLogger()
	{
		Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "ScreenLogger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr);
		ScreenLogger.NativeFieldInfoPtr_msgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, "msgs");
		ScreenLogger.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, "delay");
		ScreenLogger.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, "x");
		ScreenLogger.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, "y");
		ScreenLogger.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, "width");
		ScreenLogger.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, "height");
		ScreenLogger.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, "_instance");
		ScreenLogger.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, "style");
		ScreenLogger.NativeMethodInfoPtr_Log_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, 100663528);
		ScreenLogger.NativeMethodInfoPtr_get_instance_Private_Static_get_ScreenLogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, 100663529);
		ScreenLogger.NativeMethodInfoPtr_writeMsg_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, 100663530);
		ScreenLogger.NativeMethodInfoPtr_doWrite_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, 100663531);
		ScreenLogger.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, 100663532);
		ScreenLogger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, 100663533);
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0001471C File Offset: 0x0001291C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 983447, RefRangeEnd = 983449, XrefRangeStart = 983420, XrefRangeEnd = 983447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log(string msg)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger.NativeMethodInfoPtr_Log_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000136 RID: 310 RVA: 0x00014754 File Offset: 0x00012954
	public unsafe static ScreenLogger instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983449, XrefRangeEnd = 983468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger.NativeMethodInfoPtr_get_instance_Private_Static_get_ScreenLogger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScreenLogger>(intPtr3) : null;
		}
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00014788 File Offset: 0x00012988
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983468, XrefRangeEnd = 983475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void writeMsg(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger.NativeMethodInfoPtr_writeMsg_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000138 RID: 312 RVA: 0x000147CC File Offset: 0x000129CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983475, XrefRangeEnd = 983481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator doWrite(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger.NativeMethodInfoPtr_doWrite_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0001481C File Offset: 0x00012A1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983481, XrefRangeEnd = 983504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00014850 File Offset: 0x00012A50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983504, XrefRangeEnd = 983525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenLogger()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600013B RID: 315 RVA: 0x000028DB File Offset: 0x00000ADB
	public ScreenLogger(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x0600013C RID: 316 RVA: 0x0001488C File Offset: 0x00012A8C
	// (set) Token: 0x0600013D RID: 317 RVA: 0x000028E4 File Offset: 0x00000AE4
	public unsafe List<string> msgs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_msgs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_msgs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x0600013E RID: 318 RVA: 0x000148BC File Offset: 0x00012ABC
	// (set) Token: 0x0600013F RID: 319 RVA: 0x00002903 File Offset: 0x00000B03
	public unsafe float delay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_delay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_delay)) = value;
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000140 RID: 320 RVA: 0x000148E4 File Offset: 0x00012AE4
	// (set) Token: 0x06000141 RID: 321 RVA: 0x0000291E File Offset: 0x00000B1E
	public unsafe int x
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_x);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_x)) = value;
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000142 RID: 322 RVA: 0x0001490C File Offset: 0x00012B0C
	// (set) Token: 0x06000143 RID: 323 RVA: 0x00002939 File Offset: 0x00000B39
	public unsafe int y
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_y);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_y)) = value;
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06000144 RID: 324 RVA: 0x00014934 File Offset: 0x00012B34
	// (set) Token: 0x06000145 RID: 325 RVA: 0x00002954 File Offset: 0x00000B54
	public unsafe int width
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_width);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_width)) = value;
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x06000146 RID: 326 RVA: 0x0001495C File Offset: 0x00012B5C
	// (set) Token: 0x06000147 RID: 327 RVA: 0x0000296F File Offset: 0x00000B6F
	public unsafe int height
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_height);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_height)) = value;
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000148 RID: 328 RVA: 0x00014984 File Offset: 0x00012B84
	// (set) Token: 0x06000149 RID: 329 RVA: 0x0000298A File Offset: 0x00000B8A
	public unsafe static ScreenLogger _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ScreenLogger.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenLogger>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ScreenLogger.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x0600014A RID: 330 RVA: 0x000149AC File Offset: 0x00012BAC
	// (set) Token: 0x0600014B RID: 331 RVA: 0x0000299C File Offset: 0x00000B9C
	public unsafe GUIStyle style
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_style);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000C3 RID: 195
	private static readonly IntPtr NativeFieldInfoPtr_msgs;

	// Token: 0x040000C4 RID: 196
	private static readonly IntPtr NativeFieldInfoPtr_delay;

	// Token: 0x040000C5 RID: 197
	private static readonly IntPtr NativeFieldInfoPtr_x;

	// Token: 0x040000C6 RID: 198
	private static readonly IntPtr NativeFieldInfoPtr_y;

	// Token: 0x040000C7 RID: 199
	private static readonly IntPtr NativeFieldInfoPtr_width;

	// Token: 0x040000C8 RID: 200
	private static readonly IntPtr NativeFieldInfoPtr_height;

	// Token: 0x040000C9 RID: 201
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x040000CA RID: 202
	private static readonly IntPtr NativeFieldInfoPtr_style;

	// Token: 0x040000CB RID: 203
	private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_String_0;

	// Token: 0x040000CC RID: 204
	private static readonly IntPtr NativeMethodInfoPtr_get_instance_Private_Static_get_ScreenLogger_0;

	// Token: 0x040000CD RID: 205
	private static readonly IntPtr NativeMethodInfoPtr_writeMsg_Private_Void_String_0;

	// Token: 0x040000CE RID: 206
	private static readonly IntPtr NativeMethodInfoPtr_doWrite_Private_IEnumerator_String_0;

	// Token: 0x040000CF RID: 207
	private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	// Token: 0x040000D0 RID: 208
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200019E RID: 414
	[ObfuscatedName("ScreenLogger+<doWrite>d__11")]
	public sealed class _doWrite_d__11 : global::Il2CppSystem.Object
	{
		// Token: 0x0600143A RID: 5178 RVA: 0x0004F840 File Offset: 0x0004DA40
		// Note: this type is marked as 'beforefieldinit'.
		static _doWrite_d__11()
		{
			Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenLogger>.NativeClassPtr, "<doWrite>d__11");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr);
			ScreenLogger._doWrite_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr, "<>1__state");
			ScreenLogger._doWrite_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr, "<>2__current");
			ScreenLogger._doWrite_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr, "<>4__this");
			ScreenLogger._doWrite_d__11.NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr, "msg");
			ScreenLogger._doWrite_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr, 100663534);
			ScreenLogger._doWrite_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr, 100663535);
			ScreenLogger._doWrite_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr, 100663536);
			ScreenLogger._doWrite_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr, 100663537);
			ScreenLogger._doWrite_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr, 100663538);
			ScreenLogger._doWrite_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr, 100663539);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0004F934 File Offset: 0x0004DB34
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _doWrite_d__11(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenLogger._doWrite_d__11>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger._doWrite_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0004F97C File Offset: 0x0004DB7C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger._doWrite_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0004F9B0 File Offset: 0x0004DBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983404, XrefRangeEnd = 983415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger._doWrite_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0004F9EC File Offset: 0x0004DBEC
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger._doWrite_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0004FA2C File Offset: 0x0004DC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983415, XrefRangeEnd = 983420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger._doWrite_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0004FA60 File Offset: 0x0004DC60
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenLogger._doWrite_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0000B734 File Offset: 0x00009934
		public _doWrite_d__11(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0004FAA0 File Offset: 0x0004DCA0
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x0000B73D File Offset: 0x0000993D
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger._doWrite_d__11.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger._doWrite_d__11.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0004FAC8 File Offset: 0x0004DCC8
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x0000B758 File Offset: 0x00009958
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger._doWrite_d__11.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger._doWrite_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0004FAF8 File Offset: 0x0004DCF8
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0000B777 File Offset: 0x00009977
		public unsafe ScreenLogger __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger._doWrite_d__11.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenLogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger._doWrite_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0004FB28 File Offset: 0x0004DD28
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x0000B796 File Offset: 0x00009996
		public unsafe string msg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger._doWrite_d__11.NativeFieldInfoPtr_msg);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScreenLogger._doWrite_d__11.NativeFieldInfoPtr_msg), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeFieldInfoPtr_msg;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
