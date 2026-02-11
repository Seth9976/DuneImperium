using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000034 RID: 52
	public static class CommandBufferPool : Object
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x0001E068 File Offset: 0x0001C268
		// Note: this type is marked as 'beforefieldinit'.
		static CommandBufferPool()
		{
			Il2CppClassPointerStore<CommandBufferPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CommandBufferPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandBufferPool>.NativeClassPtr);
			CommandBufferPool.NativeFieldInfoPtr_s_BufferPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandBufferPool>.NativeClassPtr, "s_BufferPool");
			CommandBufferPool.NativeMethodInfoPtr_Get_Public_Static_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferPool>.NativeClassPtr, 100663847);
			CommandBufferPool.NativeMethodInfoPtr_Get_Public_Static_CommandBuffer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferPool>.NativeClassPtr, 100663848);
			CommandBufferPool.NativeMethodInfoPtr_Release_Public_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferPool>.NativeClassPtr, 100663849);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 958986, RefRangeEnd = 958988, XrefRangeStart = 958976, XrefRangeEnd = 958986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CommandBuffer Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferPool.NativeMethodInfoPtr_Get_Public_Static_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr3) : null;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0001E11C File Offset: 0x0001C31C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 958996, RefRangeEnd = 958999, XrefRangeStart = 958988, XrefRangeEnd = 958996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CommandBuffer Get(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferPool.NativeMethodInfoPtr_Get_Public_Static_CommandBuffer_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0001E160 File Offset: 0x0001C360
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 959027, RefRangeEnd = 959030, XrefRangeStart = 958999, XrefRangeEnd = 959027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(CommandBuffer buffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferPool.NativeMethodInfoPtr_Release_Public_Static_Void_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00003F2B File Offset: 0x0000212B
		public CommandBufferPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0001E198 File Offset: 0x0001C398
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00003F34 File Offset: 0x00002134
		public unsafe static ObjectPool<CommandBuffer> s_BufferPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CommandBufferPool.NativeFieldInfoPtr_s_BufferPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<CommandBuffer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommandBufferPool.NativeFieldInfoPtr_s_BufferPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeFieldInfoPtr_s_BufferPool;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_CommandBuffer_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_CommandBuffer_String_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_CommandBuffer_0;

		// Token: 0x0200015C RID: 348
		[ObfuscatedName("UnityEngine.Rendering.CommandBufferPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060015E9 RID: 5609 RVA: 0x0005F0AC File Offset: 0x0005D2AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CommandBufferPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CommandBufferPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandBufferPool.__c>.NativeClassPtr);
				CommandBufferPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandBufferPool.__c>.NativeClassPtr, "<>9");
				CommandBufferPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferPool.__c>.NativeClassPtr, 100663852);
				CommandBufferPool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferPool.__c>.NativeClassPtr, 100663853);
			}

			// Token: 0x060015EA RID: 5610 RVA: 0x0005F114 File Offset: 0x0005D314
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandBufferPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015EB RID: 5611 RVA: 0x0005F150 File Offset: 0x0005D350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958974, XrefRangeEnd = 958976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__4_0(CommandBuffer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferPool.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015EC RID: 5612 RVA: 0x0000B171 File Offset: 0x00009371
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x060015ED RID: 5613 RVA: 0x0005F194 File Offset: 0x0005D394
			// (set) Token: 0x060015EE RID: 5614 RVA: 0x0000B17A File Offset: 0x0000937A
			public unsafe static CommandBufferPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CommandBufferPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBufferPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CommandBufferPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FF2 RID: 4082
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000FF3 RID: 4083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000FF4 RID: 4084
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_CommandBuffer_0;
		}
	}
}
