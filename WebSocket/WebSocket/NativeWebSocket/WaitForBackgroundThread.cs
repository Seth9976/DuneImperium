using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;

namespace NativeWebSocket
{
	// Token: 0x0200000B RID: 11
	public class WaitForBackgroundThread : Object
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000033A0 File Offset: 0x000015A0
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForBackgroundThread()
		{
			Il2CppClassPointerStore<WaitForBackgroundThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("WebSocket.dll", "NativeWebSocket", "WaitForBackgroundThread");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForBackgroundThread>.NativeClassPtr);
			WaitForBackgroundThread.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForBackgroundThread>.NativeClassPtr, 100663333);
			WaitForBackgroundThread.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForBackgroundThread>.NativeClassPtr, 100663334);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000033F8 File Offset: 0x000015F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262505, RefRangeEnd = 1262507, XrefRangeStart = 1262485, XrefRangeEnd = 1262505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForBackgroundThread.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(intPtr);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003430 File Offset: 0x00001630
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForBackgroundThread()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForBackgroundThread>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForBackgroundThread.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000216D File Offset: 0x0000036D
		public WaitForBackgroundThread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000013 RID: 19
		[ObfuscatedName("NativeWebSocket.WaitForBackgroundThread+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000095 RID: 149 RVA: 0x00004724 File Offset: 0x00002924
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WaitForBackgroundThread.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForBackgroundThread>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForBackgroundThread.__c>.NativeClassPtr);
				WaitForBackgroundThread.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForBackgroundThread.__c>.NativeClassPtr, "<>9");
				WaitForBackgroundThread.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForBackgroundThread.__c>.NativeClassPtr, "<>9__0_0");
				WaitForBackgroundThread.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForBackgroundThread.__c>.NativeClassPtr, 100663336);
				WaitForBackgroundThread.__c.NativeMethodInfoPtr__GetAwaiter_b__0_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForBackgroundThread.__c>.NativeClassPtr, 100663337);
			}

			// Token: 0x06000096 RID: 150 RVA: 0x000047A0 File Offset: 0x000029A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForBackgroundThread.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForBackgroundThread.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000097 RID: 151 RVA: 0x000047DC File Offset: 0x000029DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetAwaiter_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForBackgroundThread.__c.NativeMethodInfoPtr__GetAwaiter_b__0_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000098 RID: 152 RVA: 0x000024BE File Offset: 0x000006BE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000099 RID: 153 RVA: 0x00004810 File Offset: 0x00002A10
			// (set) Token: 0x0600009A RID: 154 RVA: 0x000024C7 File Offset: 0x000006C7
			public unsafe static WaitForBackgroundThread.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WaitForBackgroundThread.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForBackgroundThread.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WaitForBackgroundThread.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600009B RID: 155 RVA: 0x00004838 File Offset: 0x00002A38
			// (set) Token: 0x0600009C RID: 156 RVA: 0x000024D9 File Offset: 0x000006D9
			public unsafe static Action __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WaitForBackgroundThread.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WaitForBackgroundThread.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400006B RID: 107
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400006C RID: 108
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400006D RID: 109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400006E RID: 110
			private static readonly IntPtr NativeMethodInfoPtr__GetAwaiter_b__0_0_Internal_Void_0;
		}
	}
}
