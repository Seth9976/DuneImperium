using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppMono.Options
{
	// Token: 0x0200000D RID: 13
	public class ArgumentSource : Object
	{
		// Token: 0x060000AE RID: 174 RVA: 0x000072D8 File Offset: 0x000054D8
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentSource()
		{
			Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "Mono.Options", "ArgumentSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr);
			ArgumentSource.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr, 100663417);
			ArgumentSource.NativeMethodInfoPtr_GetNames_Public_Abstract_Virtual_New_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr, 100663418);
			ArgumentSource.NativeMethodInfoPtr_get_Description_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr, 100663419);
			ArgumentSource.NativeMethodInfoPtr_GetArguments_Public_Abstract_Virtual_New_Boolean_String_byref_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr, 100663420);
			ArgumentSource.NativeMethodInfoPtr_GetArgumentsFromFile_Public_Static_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr, 100663421);
			ArgumentSource.NativeMethodInfoPtr_GetArguments_Public_Static_IEnumerable_1_String_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr, 100663422);
			ArgumentSource.NativeMethodInfoPtr_GetArguments_Private_Static_IEnumerable_1_String_TextReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr, 100663423);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007394 File Offset: 0x00005594
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000073D0 File Offset: 0x000055D0
		[CallerCount(0)]
		public unsafe virtual Il2CppStringArray GetNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentSource.NativeMethodInfoPtr_GetNames_Public_Abstract_Virtual_New_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000741C File Offset: 0x0000561C
		public unsafe virtual string Description
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentSource.NativeMethodInfoPtr_get_Description_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00007460 File Offset: 0x00005660
		[CallerCount(0)]
		public unsafe virtual bool GetArguments(string value, out IEnumerable<string> replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentSource.NativeMethodInfoPtr_GetArguments_Public_Abstract_Virtual_New_Boolean_String_byref_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			replacement = ((intPtr4 == 0) ? null : new IEnumerable<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000074DC File Offset: 0x000056DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166222, XrefRangeEnd = 1166224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> GetArgumentsFromFile(string file)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource.NativeMethodInfoPtr_GetArgumentsFromFile_Public_Static_IEnumerable_1_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00007520 File Offset: 0x00005720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166224, XrefRangeEnd = 1166225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> GetArguments(TextReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource.NativeMethodInfoPtr_GetArguments_Public_Static_IEnumerable_1_String_TextReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00007564 File Offset: 0x00005764
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1166231, RefRangeEnd = 1166234, XrefRangeStart = 1166225, XrefRangeEnd = 1166231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> GetArguments(TextReader reader, bool close)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref close;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource.NativeMethodInfoPtr_GetArguments_Private_Static_IEnumerable_1_String_TextReader_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000242F File Offset: 0x0000062F
		public ArgumentSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_GetNames_Public_Abstract_Virtual_New_Il2CppStringArray_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_GetArguments_Public_Abstract_Virtual_New_Boolean_String_byref_IEnumerable_1_String_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_GetArgumentsFromFile_Public_Static_IEnumerable_1_String_String_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_GetArguments_Public_Static_IEnumerable_1_String_TextReader_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetArguments_Private_Static_IEnumerable_1_String_TextReader_Boolean_0;

		// Token: 0x02000060 RID: 96
		[ObfuscatedName("Mono.Options.ArgumentSource+<GetArguments>d__7")]
		public sealed class _GetArguments_d__7 : Object
		{
			// Token: 0x060003E6 RID: 998 RVA: 0x00011F60 File Offset: 0x00010160
			// Note: this type is marked as 'beforefieldinit'.
			static _GetArguments_d__7()
			{
				Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArgumentSource>.NativeClassPtr, "<GetArguments>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr);
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "<>1__state");
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "<>2__current");
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "<>l__initialThreadId");
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "reader");
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___3__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "<>3__reader");
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr_close = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "close");
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___3__close = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "<>3__close");
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__arg_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "<arg>5__2");
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__line_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "<line>5__3");
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__t_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "<t>5__4");
				ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, "<i>5__5");
				ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, 100663424);
				ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, 100663425);
				ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, 100663426);
				ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, 100663427);
				ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, 100663428);
				ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, 100663429);
				ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, 100663430);
				ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, 100663431);
				ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr, 100663432);
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x0001211C File Offset: 0x0001031C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetArguments_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentSource._GetArguments_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x00012164 File Offset: 0x00010364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166181, XrefRangeEnd = 1166183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x00012198 File Offset: 0x00010398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166183, XrefRangeEnd = 1166209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x000121D4 File Offset: 0x000103D4
			[CallerCount(0)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x060003EB RID: 1003 RVA: 0x00012208 File Offset: 0x00010408
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x00012240 File Offset: 0x00010440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166209, XrefRangeEnd = 1166214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x060003ED RID: 1005 RVA: 0x00012274 File Offset: 0x00010474
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x000122B4 File Offset: 0x000104B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166214, XrefRangeEnd = 1166222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x000122F4 File Offset: 0x000104F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentSource._GetArguments_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x00003EA5 File Offset: 0x000020A5
			public _GetArguments_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00012334 File Offset: 0x00010534
			// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00003EAE File Offset: 0x000020AE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0001235C File Offset: 0x0001055C
			// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00003EC9 File Offset: 0x000020C9
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00012384 File Offset: 0x00010584
			// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00003EE8 File Offset: 0x000020E8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000123AC File Offset: 0x000105AC
			// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00003F03 File Offset: 0x00002103
			public unsafe TextReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000123DC File Offset: 0x000105DC
			// (set) Token: 0x060003FA RID: 1018 RVA: 0x00003F22 File Offset: 0x00002122
			public unsafe TextReader __3__reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___3__reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___3__reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x060003FB RID: 1019 RVA: 0x0001240C File Offset: 0x0001060C
			// (set) Token: 0x060003FC RID: 1020 RVA: 0x00003F41 File Offset: 0x00002141
			public unsafe bool close
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr_close);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr_close)) = value;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x060003FD RID: 1021 RVA: 0x00012434 File Offset: 0x00010634
			// (set) Token: 0x060003FE RID: 1022 RVA: 0x00003F5C File Offset: 0x0000215C
			public unsafe bool __3__close
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___3__close);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr___3__close)) = value;
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x060003FF RID: 1023 RVA: 0x0001245C File Offset: 0x0001065C
			// (set) Token: 0x06000400 RID: 1024 RVA: 0x00003F77 File Offset: 0x00002177
			public unsafe StringBuilder _arg_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__arg_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__arg_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000401 RID: 1025 RVA: 0x0001248C File Offset: 0x0001068C
			// (set) Token: 0x06000402 RID: 1026 RVA: 0x00003F96 File Offset: 0x00002196
			public unsafe string _line_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__line_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__line_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x000124B4 File Offset: 0x000106B4
			// (set) Token: 0x06000404 RID: 1028 RVA: 0x00003FB5 File Offset: 0x000021B5
			public unsafe int _t_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__t_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__t_5__4)) = value;
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000405 RID: 1029 RVA: 0x000124DC File Offset: 0x000106DC
			// (set) Token: 0x06000406 RID: 1030 RVA: 0x00003FD0 File Offset: 0x000021D0
			public unsafe int _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentSource._GetArguments_d__7.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04000277 RID: 631
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000278 RID: 632
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000279 RID: 633
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400027A RID: 634
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x0400027B RID: 635
			private static readonly IntPtr NativeFieldInfoPtr___3__reader;

			// Token: 0x0400027C RID: 636
			private static readonly IntPtr NativeFieldInfoPtr_close;

			// Token: 0x0400027D RID: 637
			private static readonly IntPtr NativeFieldInfoPtr___3__close;

			// Token: 0x0400027E RID: 638
			private static readonly IntPtr NativeFieldInfoPtr__arg_5__2;

			// Token: 0x0400027F RID: 639
			private static readonly IntPtr NativeFieldInfoPtr__line_5__3;

			// Token: 0x04000280 RID: 640
			private static readonly IntPtr NativeFieldInfoPtr__t_5__4;

			// Token: 0x04000281 RID: 641
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04000282 RID: 642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000283 RID: 643
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000284 RID: 644
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000285 RID: 645
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000286 RID: 646
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x04000287 RID: 647
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000288 RID: 648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000289 RID: 649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x0400028A RID: 650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
